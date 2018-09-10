from flask import Flask, request
import requests
import sqlite3
import json
import hashlib
import os
import logging
from reportlab.graphics.shapes import Rect
from reportlab.lib.pagesizes import letter
from reportlab.pdfgen import canvas
from reportlab.lib.colors import lightblue, black, blue
from twilio.rest import Client

logging.basicConfig(level=logging.DEBUG)
log = logging.getLogger(__name__)


class EmpadiController:
    def __init__(self):
        self.short_url = ""
        #self.conn = sqlite3.connect("tickets.db")
        self.domain = "ec2-18-191-203-36.us-east-2.compute.amazonaws.com"
        self.server_url = "http://" + self.domain #+ ":5000/"
        #self.cur = self.conn.cursor()
        self.apache_path = "/var/www/html/"
        self.f_name = "ticket.pdf"
        self.f_hash_str = None

    def create_ticket(self, data):
        if data is not None:
            self.__create_pdf(data)
        self.__store_file()
        return self.__short_url()

    def __create_pdf(self, data: dict):
        print(data)
        c = canvas.Canvas(self.apache_path + self.f_name, pagesize=letter)
        c.drawImage("logoBBVA.jpg",10,650, width=200, height=180)
        c.setFont("Helvetica",12)
        c.setFillColor(blue)
        c.setFont("Helvetica",18)
        c.drawString(26,670,"Comprar/Contratar-Pago automático de Tarjeta de")
        c.drawString(26,650,"Crédito")
        c.setFont("Helvetica",14)
        c.setFillColor(black)
        c.drawString(26,630,"Comprobante digital- Cajero Automático")
        c.setFont("Helvetica",12)
        c.drawString(150,610,"No. de cajero:       D001")
        c.drawString(116,590,"Ubicación de cajero:       PRACT 2100XE CO")
        c.drawString(137,570,"Cuenta de retiro:       " + data["noCuenta"])
        c.drawString(123,550,"Tipo operación:       " + data["tipoOperacion"] )
        c.drawString(133,530,"Importe ingresado:       ")
        c.drawString(118,510,"Importe depositado:       " + data["monto"])
        c.drawString(125,490,"Motivo de pago:       ")
        c.drawString(125,470,"Fecha de operación:       " + data["fecha"])
        c.drawString(124,450,"Folio de operación:       " + data["numeroTransaccion"])
        c.drawString(150,430,"Ciudad:        " + data["ciudadOrigen"])
        c.setFillColor(lightblue)
        c.rect(26,290,410,120, fill = True, stroke=False)
        c.setFillColor(black)
        c.setFont("Helvetica",13)
        c.drawString(29,390,"En caso de no reconocer esta operación, comunícate al 01800 22 62")
        c.drawString(29,370,"663")
        c.drawString(29,350,"Este documento constituye una notificación de los términos en")
        c.drawString(29,330,"que se realizo la operación, el unico comprobante oficial es el estado")
        c.drawString(29,310,"de cuenta que emite BBVA Bancomer.")
        c.save()

    def send_sms(self):
        account_sid = 'AC747e71bccd71f5b22518b9816201a2a3'
        auth_token = '07631880370761a742b614de5a23011d' 
        myPhone = '+524421164682' 
        TwilioNumber = '+18125787365' 
        client = Client(account_sid, auth_token)
        client.messages.create(
            to = myPhone,
            from_ = TwilioNumber,
        body='En el siguiente enlace encontraras tu comprobante electronico '+ self.short_url +' Gracias por usar nuestros servicios Bancomer'+ u'\U0001f680')

    def __store_file(self):
        with open(self.apache_path + self.f_name, "rb") as f:
            self.f_hash_str = str(hashlib.sha256(f.read()).hexdigest())
            os.rename(self.apache_path + self.f_name, self.apache_path + "consult/" + self.f_hash_str + ".pdf")

    def __short_url(self):
        url_target = self.server_url + "/consult/" + self.f_hash_str + ".pdf"
        shortener_url = "https://api.rebrandly.com/v1/links"
        api_key = "51b9f465980d4ef4b16dcaeab2b46a6d"
        data = json.dumps({"destination": url_target, "domain":
            {"fullName": "rebrand.ly"}})
        headers = {"Content-type": "application/json", "apikey": api_key}
        r = requests.post(shortener_url, data=data, headers=headers)
        if r.status_code == requests.codes.ok:
            link = r.json()
            log.debug("url original: {}\nurl corta: {}".format(link["destination"], link["shortUrl"]))
            self.short_url = link["shortUrl"]
            petition_response = {"shortUrl": link["shortUrl"]}
        else:
            petition_response = {"shortUrl": ''}
        return json.dumps(petition_response)


controller = EmpadiController()

app = Flask(__name__)


@app.route("/")
def raiz():
    return "raiz"


@app.route("/create", methods=['POST'])
def create():
    """log.debug("create function triggered")
    data = request.get_json()
    create_digital_ticket(data)
    url_destino = "http://www.google.com"
    shortener_url = "https://api.rebrandly.com/v1/links"
    api_key = "51b9f465980d4ef4b16dcaeab2b46a6d"
    data = json.dumps({"destination": url_destino, "domain":
                      {"fullName": "rebrand.ly"}})
    headers={"Content-type": "application/json", "apikey": api_key}
    r = requests.post(shortener_url, data=data, headers=headers)
    if r.status_code == requests.codes.ok:
        link = r.json()
        log.debug("url original: {}\nurl corta: {}".format(link["destination"], link["shortUrl"]))"""
    return controller.create_ticket(request.get_json())

@app.route("/sms", methods=['POST'])
def send_sms():
    # j = request.get_json()
    controller.send_sms()
    return "{\"status\": \"Sent Message\"}"

@app.route("/consult/<ticketid>")
def consult(ticketid):
    pass

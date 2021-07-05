using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Xml;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Minesweeper.Models
{
    public class Server
    {
        HttpWebRequest request = null;
        public Server()
        {

        }
        
        private class EndPoint
        {
            public static string BaseUrl => "https://prateleira.utad.priv:1234/LPDSW/2019-2020";
            public static string PostRegisto => "/registo";
            public static string PostLogin => "/autentica";
            public static string GetNovoJogo => "/novo";
            public static string PostRegistoResultado => "/resultado";
            public static string GetPerfil => "/perfil";
            public static string GetTop10 => "/top10";
        }

        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) 
        {  
            return true; 
        }

        public string Login(string username, string password)
        {
            XDocument xmlPedido = null;
            string mensagem = string.Empty;
            byte[] data = null;
            Stream newStream = null;
            HttpWebResponse response = null;
            StreamReader readStream = null;
            string resultado = string.Empty;
            Stream receiveStream = null;
            XDocument xmlResposta = null;
            string ID = string.Empty;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(EndPoint.BaseUrl + EndPoint.PostLogin);
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                xmlPedido = XDocument.Parse("<credenciais><username></username><password></password></credenciais>");

                xmlPedido.Element("credenciais").Element("username").Value = username;
                xmlPedido.Element("credenciais").Element("password").Value = password;

                mensagem = xmlPedido.Root.ToString();

                data = Encoding.Default.GetBytes(mensagem);
                request.Method = "POST";
                request.ContentType = "application/xml";
                request.ContentLength = data.Length;

                newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

                response = (HttpWebResponse)request.GetResponse();
                receiveStream = response.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                response.Close();
                readStream.Close();

                xmlResposta = XDocument.Parse(resultado);

            }
            catch (Exception ex)
            {
                return string.Empty;
            }
            if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
            {
                return string.Empty;
            }
            else
            {
                
                return xmlResposta.Element("resultado").Element("objeto").Element("ID").Value;
            }
               
        }

        public string RegistarNovoUtilizador(string novoUser, string novoNome, string novaPass, string novoMail, string novaFoto, string novoPais)
        {
          
            XDocument xmlpedido = null;
            string mensagem = string.Empty;
            byte[] data = null;
            Stream newStream = null;
            HttpWebResponse response = null;
            StreamReader readStream = null;
            string resultado = string.Empty;
            Stream receiveStream = null;
            XDocument xmlResposta = null;
            string ID = string.Empty;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(EndPoint.BaseUrl + EndPoint.PostRegisto);
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                xmlpedido = XDocument.Parse("<registo><nomeabreviado></nomeabreviado><username></username><password></password><email></email><fotografia></fotografia><pais></pais></registo>");

                xmlpedido.Element("registo").Element("nomeabreviado").Value = novoNome;
                xmlpedido.Element("registo").Element("username").Value = novoUser;
                xmlpedido.Element("registo").Element("password").Value = novaPass;
                xmlpedido.Element("registo").Element("email").Value = novoMail;
                xmlpedido.Element("registo").Element("fotografia").Value = novaFoto;
                xmlpedido.Element("registo").Element("pais").Value = novoPais;

                mensagem = xmlpedido.Root.ToString();
                data = Encoding.Default.GetBytes(mensagem);
                request.Method = "POST";
                request.ContentType = "application/xml";
                request.ContentLength = data.Length;

                newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

                response = (HttpWebResponse)request.GetResponse();
                receiveStream = response.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                response.Close();
                readStream.Close();

                xmlResposta = XDocument.Parse(resultado);

                if (xmlResposta.Element("resultado").Element("status").Value == "Erro")
                {
                    ID = string.Empty;
                }
                else
                {
                    ID = xmlResposta.Element("resultado").Element("objeto").Value;
                }

            }
            catch(Exception ex)
            {
            }
            return "Utilizador registado com sucesso";
        }

        public string RegistoJogo(string nivel, int tempo, string vitoria, string id)
        {
            XDocument xmlpedido = null;
            string mensagem = string.Empty;
            byte[] data = null;
            Stream newStream = null;
            HttpWebResponse response = null;
            StreamReader readStream = null;
            string resultado = string.Empty;
            Stream receiveStream = null;
            XDocument xmlResposta = null;
            

            try
            {
                request = (HttpWebRequest)WebRequest.Create(EndPoint.BaseUrl + EndPoint.PostRegistoResultado + "/" + id);
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                xmlpedido = XDocument.Parse("<resultado_jogo><nivel></nivel><tempo></tempo><vitoria></vitoria></resultado_jogo>");

                xmlpedido.Element("resultado_jogo").Element("nivel").Value = nivel;
                xmlpedido.Element("resultado_jogo").Element("tempo").Value = tempo.ToString();
                xmlpedido.Element("resultado_jogo").Element("vitoria").Value = vitoria;

                mensagem = xmlpedido.Root.ToString();
                data = Encoding.Default.GetBytes(mensagem);
                request.Method = "POST";
                request.ContentType = "application/xml";
                request.ContentLength = data.Length;


                newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

                response = (HttpWebResponse)request.GetResponse();
                receiveStream = response.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                response.Close();
                readStream.Close();

                xmlResposta = XDocument.Parse(resultado);
                
            }
            catch (Exception ex)
            {

            }


            return "OK";
        }

        public XDocument GetPerfil(string UserName)
        {
            XDocument umPerfil = null;
            HttpWebResponse response = null;
            string resultado = string.Empty;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(EndPoint.BaseUrl + EndPoint.GetPerfil + "/" + UserName);
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                request.Method = "GET";
                request.ContentType = "application/xml";

                response = (HttpWebResponse)request.GetResponse();

                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                response.Close();
                readStream.Close();

                umPerfil = XDocument.Parse(resultado);

                return umPerfil;
            }
            catch(Exception ex)
            {
                return umPerfil;
                
            }

         
        }

        public XDocument UpdateLead()
        {
            XDocument top = null;
            HttpWebResponse response = null;
            string resultado = string.Empty;

            request = (HttpWebRequest)WebRequest.Create(EndPoint.BaseUrl + EndPoint.GetTop10);
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

            request.Method = "GET";
            request.ContentType = "application/xml";

            response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            resultado = readStream.ReadToEnd();
            response.Close();
            readStream.Close();

            top = XDocument.Parse(resultado);

            return top;
        }


        public XDocument GetMap(string username, string dificuldade)
        {
            XDocument mapa = null;

            HttpWebResponse response = null;
            string resultado = string.Empty;

            request = (HttpWebRequest)WebRequest.Create(EndPoint.BaseUrl + EndPoint.GetNovoJogo + "/" + dificuldade + "/" + username);
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

            request.Method = "GET";
            request.ContentType = "application/xml";

            response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            resultado = readStream.ReadToEnd();
            response.Close();
            readStream.Close();

            mapa = XDocument.Parse(resultado);

            return mapa;
        }
       
    }
}

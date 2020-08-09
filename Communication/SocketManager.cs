using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace SerialComTESTProgram
{
    public class SocketManager
    {
        private TcpClient m_TCPClient;
        private MainForm m_MainForm;
        //byte []buf = new byte[1024];
        public SocketManager(MainForm Form)
        {
            //IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 8088);
            //m_Socket.Bind(ipep);
            //m_Socket.Listen(10);

            this.m_MainForm = Form;
        }

        public bool Connenct(string Address, int PortNum)
        {
            try
            {
                //IPAddress aa = 169.120.7.0;
                if (m_TCPClient != null && m_TCPClient.Connected)
                {
                    m_TCPClient.Close();
                    Thread.Sleep(3000);
                }
                if (m_TCPClient == null)
                {
                    m_TCPClient = new TcpClient(Address, PortNum);
                    //m_TCPClient.Connect()   
                }
                           
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }           
        }

        public bool Disconnenct(string Address, int PortNum)
        {
            try
            {
                m_TCPClient.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool SendCommand(string text)
        {
            byte[] buff = Encoding.ASCII.GetBytes(text);
            NetworkStream stream = m_TCPClient.GetStream();
            try
            {
                stream.Write(buff, 0, buff.Length);

                byte[] outbuf = new byte[1024];
                int nbytes = stream.Read(outbuf, 0, outbuf.Length);
                string output = Encoding.ASCII.GetString(outbuf, 0, nbytes);

                //byte[] outbuf = new byte[1024];
                //int nbytes;
                //MemoryStream mem = new MemoryStream();
                //while ((nbytes = stream.Read(outbuf, 0, outbuf.Length)) > 0)
                //{
                //    mem.Write(outbuf, 0, nbytes);
                //}
                //byte[] outbytes = mem.ToArray();
                //mem.Close();

                stream.Close();
                m_TCPClient.Close();
                m_MainForm.WriteReceiveText(output + Environment.NewLine);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }              
    }
}

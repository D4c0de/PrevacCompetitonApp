using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace prevacCompetition_desktopAppWinForms
{
    static public class connection
    {
        static private string ipAddress;
        static private int tcpPort;
        static public bool isConnected = false;
        static private ModbusClient modbusClient;
        static public bool isRunning = false;
        static public string serial;
        static public bool connectUsingTcp = false;
        public static void Connect()
        {

            if (connectUsingTcp)
            {
                if (string.IsNullOrEmpty(ipAddress) && tcpPort != 0)
                {
                    return;
                }
                modbusClient = new ModbusClient(ipAddress, tcpPort);
            }
            else
            {
                if (string.IsNullOrEmpty(serial))
                {
                    return;
                }
                modbusClient = new ModbusClient("serial");
            }
            modbusClient.ConnectionTimeout = 10000;
            while (!modbusClient.Available(1000))
            {
                MessageBox.Show("Connection timeout");
                return;
            }
            modbusClient.Connect();
            isConnected = true;


        }
        static public void set(string ip,int port)
        {
            ipAddress = ip;
            tcpPort = port;
        }
        static public void set(string _serial)
        {
            serial = _serial;
        }
        static public void DissConnect()
        {
            isConnected = false;
            modbusClient?.Disconnect();

        }
        public static int[] reg_read_multiply(int start, int quantity)
        {
            int[] ret = modbusClient?.ReadHoldingRegisters(start, quantity);
            return ret;
        }
        public static int reg_read_first()
        {
            int[] ret = modbusClient?.ReadHoldingRegisters(0, 1);
            return ret[0];
        }
        public static int reg_read_single(int start)
        {
            int[] ret = modbusClient?.ReadHoldingRegisters(start, 1);
            return ret[0];
        }

        public static void reg_write_multiply(int[] values)
        {
            modbusClient?.WriteSingleRegister(0, 1);
            modbusClient?.WriteMultipleRegisters(1, values);
        }

        public static void reg_write_first(int value)
        {
            modbusClient?.WriteSingleRegister(0, value);
        }

        public static void reg_write_multiply(int start, int[] values)
        {
            modbusClient?.WriteMultipleRegisters(start, values);
        }

        public static void reg_write_songle(int start, int value)
        {
            modbusClient?.WriteSingleRegister(start, value);
        }
        public static void reg_clr(int start)
        {
            int[] value = new int[10];
            modbusClient?.WriteMultipleRegisters(start, value);
        }

        public static void reg_clr()
        {
            int[] value = new int[50];
            modbusClient?.WriteMultipleRegisters(0, value);
        }
    }
}

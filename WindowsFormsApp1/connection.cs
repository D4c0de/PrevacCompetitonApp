﻿using System;
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
using WindowsFormsApp1;
using prop;

namespace prevacCompetition_desktopAppWinForms
{
    static public class connection
    {

        private static ModbusClient modbusClient;
        public static bool isConnected { get; set; }
        public static bool isRunning { get; set; }
        public static void Connect(Connections_prop connectionsProp)
        {

            if (!connectionsProp.preferRTU)
            {
                modbusClient = new ModbusClient(connectionsProp.adres, connectionsProp.port);
            }
            else
            {
                modbusClient = new ModbusClient(connectionsProp.adres);
            }
            modbusClient.ConnectionTimeout = 1000;
            modbusClient.Connect();
            reg_read_first();
            isConnected = true;
        }
        public static async Task WaitUntilRedy()
        {
            while (isRunning)
            {
                await Task.Delay(500);
            }
        }
        static public void DissConnect()
        {
            isConnected = false;
            modbusClient?.Disconnect();

        }
        public static void SendToken()
        {
            for (int i = 0; i < 6; i++)
            {
                modbusClient.WriteSingleRegister(2+i, Program.token[i]);
            }
        }
        public static void GetToken()
        {
            Program.token = new UInt16[6];
            int[] token = connection.reg_read_multiply(2, 6);
            for (int i = 0; i < token.Length; i++)
            {
                Program.token[i]= (UInt16)token[i];
            }
            reg_clr(0);
            reg_clr(2);
            reg_clr(3);
        }

        public static void Write_Auth(int[] username, int[] password)
        {
            
            connection.reg_write_songle(1, username.Length);
            connection.reg_write_songle(2, password.Length);
            connection.reg_write_multiply(3, username);
            connection.reg_write_multiply(username.Length+3, password);
            reg_write_songle(0, 4);
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
        public static void reg_write_string(int start,String text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {

            }
            string outp = stringBuilder.ToString();

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

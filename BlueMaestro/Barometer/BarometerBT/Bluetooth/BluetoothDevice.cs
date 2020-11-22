﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarometerBT.Bluetooth
{
    public class BluetoothDevice
    {
        public string Name { get; set; }
        public ulong Address { get; set; }
        public string State { get; set; }

        //for serialization
        public BluetoothDevice()
        {

        }

        public BluetoothDevice(string name, ulong address, string state)
        {
            Name = name;
            Address = address;
            State = state;
        }

        public string GetAddressString()
        {
            return ConvertAddress(Address);
        }

        public static string ConvertAddress(ulong address)
        {
            return BitConverter.ToString(BitConverter.GetBytes(address).Reverse().ToArray());
        }

        public override string ToString()
        {
            return string.Format("{0} <=> {1}", Name, BitConverter.ToString(BitConverter.GetBytes(Address).Reverse().ToArray()));
        }
    }
}

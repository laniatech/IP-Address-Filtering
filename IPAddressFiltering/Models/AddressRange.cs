﻿using System.Net;

namespace IPAddressFiltering.Models
{
    internal class AddressRange
    {
        private IPAddress startIPAddress;
        private IPAddress endIPAddress;

        public IPAddress StartIPAddress
        {
            get
            {
                return this.startIPAddress;
            }
        }

        public IPAddress EndIPAddress
        {
            get
            {
                return this.endIPAddress;
            }
        }

        public AddressRange(string startIPAddress, string endIPAddress)
            : this(IPAddress.Parse(startIPAddress), IPAddress.Parse(endIPAddress))
        {

        }
        public AddressRange(IPAddress startIPAddress, IPAddress endIPAddress)
        {
            this.startIPAddress = startIPAddress;
            this.endIPAddress = endIPAddress;
        }
    }
}

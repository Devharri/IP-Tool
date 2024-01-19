using System.Drawing.Printing;

namespace IP_ToolLibrary;

public static class SubnetMask
{
    public static long NumberOfHosts { get; set; }
    public static long NumberOfUsableHosts { get; set; }
    public static string? NetworkAddress { get; set; }
    public static string? Mask { get; set; }
    public static string? BinaryMask { get; set; }
    public static string? IPAddress { get; set; }
    public static string? BinaryIPAddress { get; set; }
    public static string? CidrNotation { get; set; }
    public static string? IPAddressWithCidr { get; set; }
    public static string? FirstUsableIP { get; set; } 
    public static string? LastUsableIP { get; set; }
    public static string? BroadcastAddress { get; set; }

    public static void CalculateAll(string subnetmask, string ipaddress)
    {
        //Call this in Calculate event
        string[] MaskOctets = subnetmask.Split(".");
        string[] IPOctets = ipaddress.Split(".");

        int SubnetmaskZeros = CalculateZeros(MaskOctets);
        IPAddress = ipaddress;
        BinaryIPAddress = ConvertOctetsToBinaryNotation(IPOctets);
        Mask = subnetmask;
        BinaryMask = ConvertOctetsToBinaryNotation(MaskOctets);
        CidrNotation = "/" + Convert.ToString(32 - SubnetmaskZeros);
        NumberOfHosts = CalculateNumberOfHosts(SubnetmaskZeros);
        NumberOfUsableHosts = ConvertHostsToUsableHosts(NumberOfHosts);
        NetworkAddress = CalculateNetworkAddress(SubnetmaskZeros, IPOctets);
        IPAddressWithCidr = ipaddress + " " + CidrNotation;
        FirstUsableIP = CalculateFirstUsableIP(NetworkAddress, NumberOfHosts);
        BroadcastAddress = CalculateBroadcastAddress(SubnetmaskZeros, NetworkAddress);
        LastUsableIP = CalculateLastUsableIP(BroadcastAddress, NumberOfHosts);
    }

    public static string CalculateFirstUsableIP(string networkAddress, long numberOfHosts)
    {
        string firstUsableIP = string.Empty;
        string[] octets = networkAddress.Split(".");
        string binaryString = ConvertOctectsToBinaryString(octets);

        firstUsableIP = Convert.ToInt32(binaryString.Substring(0, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(8, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(16, 8), 2) + "." + (Convert.ToInt32(binaryString.Substring(24, 8), 2) + 1);

        if (numberOfHosts <=2)
        {
            firstUsableIP = "NA";
        }

        return firstUsableIP;
    }
    public static string CalculateLastUsableIP(string broadcastAddress, long numberOfHosts) 
    {
        string lastUsableIP = string.Empty;
        string[] octets = broadcastAddress.Split(".");
        string binaryString = ConvertOctectsToBinaryString(octets);

        lastUsableIP = Convert.ToInt32(binaryString.Substring(0, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(8, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(16, 8), 2) + "." + (Convert.ToInt32(binaryString.Substring(24, 8), 2) - 1);

        if (numberOfHosts <= 2)
        {
            lastUsableIP = "NA";
        }

        return lastUsableIP;
    }
    public static string CalculateBroadcastAddress(int subnetZeros, string networkAddress) 
    {
        string broadcastAddress = string.Empty;
        int subnetOnes = 32 - subnetZeros;
        string[] octets = networkAddress.Split(".");
        string binaryString = ConvertOctectsToBinaryString(octets);
        binaryString = binaryString.Remove(subnetOnes);
        binaryString = binaryString.PadRight(32, '1');
        broadcastAddress = Convert.ToInt32(binaryString.Substring(0, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(8, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(16, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(24, 8), 2);

        return broadcastAddress;
    }
    public static string CalculateNetworkAddress(int subnetZeros, string[] ipOctets) 
    {
        string networkAddress = string.Empty;
        int subnetOnes = 32 - subnetZeros;
        string binaryString = ConvertOctectsToBinaryString(ipOctets);
        binaryString = binaryString.Remove(subnetOnes);
        binaryString = binaryString.PadRight(32, '0');
        networkAddress = Convert.ToInt32(binaryString.Substring(0, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(8, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(16, 8), 2) + "." + Convert.ToInt32(binaryString.Substring(24, 8),2);
        return networkAddress;
    }
    public static int CalculateZeros(string[] octets)
    {
        //Convert each octet to binary string and concatenate
        string binaryString = ConvertOctectsToBinaryString(octets);
        //count zeros from concatenated binary string 
        int zeros = binaryString.Count(x => x == '0');
        return zeros;
    }
    public static long CalculateNumberOfHosts(int subnetZeros)
    {
        return (long)Math.Pow(2, subnetZeros);
    }
    public static string ConvertOctetsToBinaryNotation(string[] octets) 
    {
        string binaryString = string.Empty;
        binaryString = ConvertOctectsToBinaryString(octets);
        binaryString = binaryString.Substring(0, 8) + "." + binaryString.Substring(8, 8) + "." + binaryString.Substring(16, 8) + "." + binaryString.Substring(24, 8);
        return binaryString;
    }
    public static string ConvertOctectsToBinaryString(string[] octets) 
    {
        string binaryString = string.Empty;
        foreach (var octet in octets)
        {
            int octetAsInteger = int.Parse(octet);
            string octetAsBinaryString = Convert.ToString(octetAsInteger, 2).PadLeft(8, '0');
            binaryString += octetAsBinaryString;
        }
        return binaryString;
    }
    public static long ConvertHostsToUsableHosts(long hosts) 
    {
        long usableHosts = 0;
        usableHosts = hosts - 2;
        if (usableHosts < 2)
        {
            usableHosts = 0;
        }
        return usableHosts;
    }
}
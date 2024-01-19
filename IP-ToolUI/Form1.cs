using IP_ToolLibrary;

namespace IP_ToolUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Confirm by pressing OK", "Exit");
        Application.Exit();
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        string ipaddress = IPTextbox1.Text + "." + IPTextbox2.Text + "." + IPTextbox3.Text + "." + IPTextbox4.Text;
        string subnetmask = SubnetmaskComboBox.Text.Remove(15);

        SubnetMask.CalculateAll(subnetmask, ipaddress);
        IPAddressTextbox.Text = SubnetMask.IPAddress;
        BinaryIPAddressTextBox.Text = SubnetMask.BinaryIPAddress;
        SubnetMaskTextBox.Text = SubnetMask.Mask;
        BinarySubnetMaskTextBox.Text = SubnetMask.BinaryMask;
        NumberOfHostsTextBox.Text = String.Format("{0:N0}", SubnetMask.NumberOfHosts);
        NumberOfUsableHostsTextBox.Text = String.Format("{0:N0}", SubnetMask.NumberOfUsableHosts);
        NetworkAddressTextBox.Text = SubnetMask.NetworkAddress;
        CidrTextBox.Text = SubnetMask.CidrNotation;
        IPAddressWithCidrTextBox.Text = SubnetMask.IPAddressWithCidr;
        FirstIpTextBox.Text = SubnetMask.FirstUsableIP;
        LastIpTextBox.Text = SubnetMask.LastUsableIP;
        BroadcastAddressTextBox.Text = SubnetMask.BroadcastAddress;
    }

    private void excelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //Export to excell 
        MessageBox.Show("Test");
    }
}
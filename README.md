# TCP Client Application (Visual Basic .NET)

`TCPclient.vb` is a Visual Basic .NET application that acts as a TCP client, allowing the user to connect to a server, send messages, and receive responses. The client establishes a connection to the TCP server on a specified IP address and port (default is `1000`). 

## Features
- **Connect to TCP Server**: Connects to a TCP server by entering the server IP address in `TextBox3` and clicking `Button1`.
- **Data Sending**: Users can type messages in `TextBox1` and send them to the server by clicking `Button2`.
- **Data Reception**: Incoming data from the server is continuously checked and displayed in `TextBox2`.

## Project Files
- **TCP_Client.sln**: Visual Studio solution file for the TCP Client application.
- **Form1.vb**: Main form code for the client, managing TCP connections, data transmission, and data reception.

## Requirements
- **.NET Framework** or **.NET Core**
- **Visual Studio** (or compatible IDE supporting VB.NET)

## How to Use
1. **Set Up the Client**:
   - Open `TCP_Client.sln` in Visual Studio.
   - Run the application, which opens a form with text boxes and buttons for IP address entry, message input, and message display.

2. **Connect to the Server**:
   - Enter the server's IP address in `TextBox3` (e.g., `192.168.0.106` for local network connections).
   - Click **Button1** to connect to the server on port `1000`.

3. **Send and Receive Messages**:
   - Type a message in `TextBox1` and click **Button2** to send it to the server.
   - Any incoming data from the server will be displayed in `TextBox2`.

## Configuration
- **IP Address**: Modify the IP address in `TextBox3` to match the server IP.
- **Port**: The default port is `1000`. Update this in `Button1_Click` if using a different port.

## Notes
- **Local IP Address**: Use `192.168.x.x` for local network testing.
- **Global IP Address**: For remote connections, use the global IP address and ensure port forwarding is set up on the router (e.g., forward port `1000` to the server's local IP address).

## Error Handling
The `Timer1_Tick` function checks if there’s data available before attempting to read, which prevents errors when no data is incoming.

## License
This project is open-source and available under the MIT License.

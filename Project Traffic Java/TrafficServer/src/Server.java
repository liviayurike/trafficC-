import javax.swing.*;
import java.awt.*;
import java.io.IOException;
import java.net.InetSocketAddress;
import java.nio.ByteBuffer;
import java.nio.channels.AsynchronousServerSocketChannel;
import java.nio.channels.AsynchronousSocketChannel;
import java.nio.channels.CompletionHandler;

public class Server {
    private JPanel JPanelRoot;
    private JTextField txtIPServer;
    private JTextField txtPortServer;
    private JButton btnListen;
    private JLabel txtStatus;
    private JPanel red;
    private JPanel yellow;
    private JPanel green;

    public Server() {
        btnListen.addActionListener(actionEvent -> listenData());
    }

    private void listenData() {
        try {
            new Thread(() -> {
                try {
                    EchoServer(txtIPServer.getText(), Integer.parseInt(txtPortServer.getText()));
                    JOptionPane.showMessageDialog(null, "Server Listening");
                    btnListen.setEnabled(false);
                } catch (IOException ioException) {
                    ioException.printStackTrace();
                }
            }).start();
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null, ex.getMessage());
        }
    }

    public static void main(String[] args) {
        JFrame gui = new JFrame("Color Picker Server");
        gui.setContentPane(new Server().JPanelRoot);
        gui.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        gui.pack();
        gui.setVisible(true);
    }

    private void EchoServer(String bindAddr, int bindPort) throws IOException{
        InetSocketAddress sockAddr = new InetSocketAddress(bindAddr, bindPort);

        //create a socket channel and bind to local bind address
        AsynchronousServerSocketChannel serverSock = AsynchronousServerSocketChannel.open().bind(sockAddr);

        //start to accept the connection from client
        serverSock.accept(serverSock, new CompletionHandler<AsynchronousSocketChannel, AsynchronousServerSocketChannel>() {

            @Override
            public void completed(AsynchronousSocketChannel sockChannel, AsynchronousServerSocketChannel serverSock) {
                //a connection is accepted, start to accept next connection
                serverSock.accept(serverSock, this);
                //start to read message from the client
                startRead(sockChannel);

            }

            @Override
            public void failed(Throwable exc, AsynchronousServerSocketChannel serverSock) {
                System.out.println("fail to accept a connection");
            }

        });
    }
    private void startRead(AsynchronousSocketChannel sockChannel) {
        final ByteBuffer buf = ByteBuffer.allocate(2048);

        //read message from client
        sockChannel.read(buf, sockChannel, new CompletionHandler<Integer, AsynchronousSocketChannel>() {

            /**
             * some message is read from client, this callback will be called
             */
            @Override
            public void completed(Integer result, AsynchronousSocketChannel channel) {
                buf.flip();

                // echo the message
                startWrite(channel, buf);

                //start to read next message again
                startRead(channel);
                String hasil = new String(buf.array());

                // menampilkan string pesan ke textfield txtPesanDiterimaServer
                if (hasil.contains("Red On")) {
                    System.out.println(hasil);
                    red.setBackground(Color.red);
                    txtStatus.setText(hasil);
                }
                if (hasil.contains("Yellow On")) {
                    System.out.println(hasil);
                    yellow.setBackground(Color.YELLOW);
                    txtStatus.setText(hasil);
                }
                if (hasil.contains("Green On")) {
                    System.out.println(hasil);
                    green.setBackground(Color.GREEN);
                    txtStatus.setText(hasil);
                }
                if (hasil.contains("Red Off")) {
                    System.out.println(hasil);
                    red.setBackground(Color.BLACK);
                    txtStatus.setText(hasil);
                }
                if (hasil.contains("Yellow Off")) {
                    System.out.println(hasil);
                    yellow.setBackground(Color.BLACK);
                    txtStatus.setText(hasil);
                }
                if (hasil.contains("Green Off")) {
                    System.out.println(hasil);
                    green.setBackground(Color.BLACK);
                    txtStatus.setText(hasil);
                }
            }

            @Override
            public void failed(Throwable exc, AsynchronousSocketChannel channel) {
                System.out.println("fail to read message from client");
            }
        });
    }
    private void startWrite(AsynchronousSocketChannel sockChannel, final ByteBuffer buf) {
        sockChannel.write(buf, sockChannel, new CompletionHandler<Integer, AsynchronousSocketChannel>() {

            @Override
            public void completed(Integer result, AsynchronousSocketChannel channel) {
                //finish to write message to client, nothing to do
            }

            @Override
            public void failed(Throwable exc, AsynchronousSocketChannel channel) {
                //fail to write message to client
                System.out.println("Fail to write message to client");
            }

        });
    }
}

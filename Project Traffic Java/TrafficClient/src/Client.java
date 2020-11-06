import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.net.InetSocketAddress;
import java.nio.ByteBuffer;
import java.nio.channels.AsynchronousSocketChannel;
import java.nio.channels.CompletionHandler;
import java.util.concurrent.atomic.AtomicInteger;

public class Client {
    private JPanel JPanelRoot;
    private JTextField txtIPClient;
    private JTextField txtPortClient;
    private JRadioButton merahON;
    private JRadioButton merahOFF;
    private JRadioButton kuningON;
    private JRadioButton kuningOFF;
    private JRadioButton hijauON;
    private JRadioButton hijauOFF;

    public Client() {
        merahON.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //JOptionPane.showMessageDialog(null, "Tombol Red On diklik");
                try {
                    AtomicInteger messageWritten = new AtomicInteger(0);
                    AtomicInteger messageRead = new AtomicInteger(0);

                    EchoClient(txtIPClient.getText(), Integer.parseInt(txtPortClient.getText()),"Red On", messageWritten, messageRead);
                } catch (Exception ex) {
                    JOptionPane.showMessageDialog(null, ex.getMessage());
                }
            }
        });
        kuningON.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //JOptionPane.showMessageDialog(null, "Tombol Yellow On diklik");
                try {
                    AtomicInteger messageWritten = new AtomicInteger(0);
                    AtomicInteger messageRead = new AtomicInteger(0);

                    EchoClient(txtIPClient.getText(), Integer.parseInt(txtPortClient.getText()),"Yellow On", messageWritten, messageRead);
                } catch (Exception ex) {
                    JOptionPane.showMessageDialog(null, ex.getMessage());
                }
            }
        });
        hijauON.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //JOptionPane.showMessageDialog(null, "Tombol Yellow On diklik");
                try {
                    AtomicInteger messageWritten = new AtomicInteger(0);
                    AtomicInteger messageRead = new AtomicInteger(0);

                    EchoClient(txtIPClient.getText(), Integer.parseInt(txtPortClient.getText()),"Green On", messageWritten, messageRead);
                } catch (Exception ex) {
                    JOptionPane.showMessageDialog(null, ex.getMessage());
                }
            }
        });
        merahOFF.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //JOptionPane.showMessageDialog(null, "Tombol Red On diklik");
                try {
                    AtomicInteger messageWritten = new AtomicInteger(0);
                    AtomicInteger messageRead = new AtomicInteger(0);

                    EchoClient(txtIPClient.getText(), Integer.parseInt(txtPortClient.getText()),"Red Off", messageWritten, messageRead);
                } catch (Exception ex) {
                    JOptionPane.showMessageDialog(null, ex.getMessage());
                }
            }
        });
        kuningOFF.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //JOptionPane.showMessageDialog(null, "Tombol Yellow On diklik");
                try {
                    AtomicInteger messageWritten = new AtomicInteger(0);
                    AtomicInteger messageRead = new AtomicInteger(0);

                    EchoClient(txtIPClient.getText(), Integer.parseInt(txtPortClient.getText()),"Yellow Off", messageWritten, messageRead);
                } catch (Exception ex) {
                    JOptionPane.showMessageDialog(null, ex.getMessage());
                }
            }
        });
        hijauOFF.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //JOptionPane.showMessageDialog(null, "Tombol Yellow On diklik");
                try {
                    AtomicInteger messageWritten = new AtomicInteger(0);
                    AtomicInteger messageRead = new AtomicInteger(0);

                    EchoClient(txtIPClient.getText(), Integer.parseInt(txtPortClient.getText()),"Green Off", messageWritten, messageRead);
                } catch (Exception ex) {
                    JOptionPane.showMessageDialog(null, ex.getMessage());
                }
            }
        });
    }

    //////////////////////////
    // Socket Client Helper //
    //////////////////////////

    public void EchoClient(String host, int port, final String message, final AtomicInteger messageWritten, final AtomicInteger messageRead) throws IOException {
        //create a socket channel
        AsynchronousSocketChannel sockChannel = AsynchronousSocketChannel.open();

        //try to connect to the server side
        sockChannel.connect(new InetSocketAddress(host, port), sockChannel, new CompletionHandler<Void, AsynchronousSocketChannel>() {
            @Override
            public void completed(Void result, AsynchronousSocketChannel channel) {
                //start to read message
                startRead(channel, messageRead);

                //write an message to server side
                startWrite(channel, String.valueOf(message), messageWritten);
            }

            @Override
            public void failed(Throwable exc, AsynchronousSocketChannel channel) {
                JOptionPane.showMessageDialog(null, "Failed to connect to Server");
            }

        });
    }

    private void startRead(final AsynchronousSocketChannel sockChannel, final AtomicInteger messageRead) {
        final ByteBuffer buf = ByteBuffer.allocate(2048);

        sockChannel.read(buf, sockChannel, new CompletionHandler<Integer, AsynchronousSocketChannel>() {

            @Override
            public void completed(Integer result, AsynchronousSocketChannel channel) {
                //message is read from server
                messageRead.getAndIncrement();

                //print the message
                System.out.println("Read message:" + new String(buf.array()));
            }

            @Override
            public void failed(Throwable exc, AsynchronousSocketChannel channel) {
                System.out.println("fail to read message from server");
            }
        });
    }

    private void startWrite(final AsynchronousSocketChannel sockChannel, final String message, final AtomicInteger messageWritten) {
        ByteBuffer buf = ByteBuffer.allocate(2048);
        buf.put(message.getBytes());
        buf.flip();
        messageWritten.getAndIncrement();
        sockChannel.write(buf, sockChannel, new CompletionHandler<Integer, AsynchronousSocketChannel>() {
            @Override
            public void completed(Integer result, AsynchronousSocketChannel channel) {
                //after message written
                //NOTHING TO DO
            }

            @Override
            public void failed(Throwable exc, AsynchronousSocketChannel channel) {
                System.out.println("Fail to write the message to server");
            }
        });
    }

    public static void main(String[] args) {
        JFrame gui = new JFrame("Traffic Color Client");
        gui.setContentPane(new Client().JPanelRoot);
        gui.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        gui.pack();
        gui.setVisible(true);
    }
}

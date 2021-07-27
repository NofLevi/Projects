
import java.awt.Color;
import java.awt.Frame;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseListener;
import javax.swing.ImageIcon;

public class Login_Screen extends javax.swing.JFrame {


    public Login_Screen() {
         setTitle("school helper program");
         ImageIcon icon;
         icon = new ImageIcon("src\\image\\icon.png");
        setIconImage(icon.getImage());
        initComponents();
        jLabel3.setVisible(false);
        
        
        
     
    }
     

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel5 = new javax.swing.JLabel();
        jTextField1 = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jPasswordField1 = new javax.swing.JPasswordField();
        jLabel3 = new javax.swing.JLabel();
        Projeck_label = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setMaximumSize(new java.awt.Dimension(800, 600));
        setMinimumSize(new java.awt.Dimension(800, 600));
        setPreferredSize(new java.awt.Dimension(800, 600));
        setResizable(false);
        getContentPane().setLayout(null);

        jLabel5.setIcon(new javax.swing.ImageIcon(getClass().getResource("/login bottun.png"))); // NOI18N
        jLabel5.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jLabel5MouseClicked(evt);
            }
        });
        getContentPane().add(jLabel5);
        jLabel5.setBounds(380, 410, 170, 70);

        jTextField1.setForeground(new java.awt.Color(204, 204, 204));
        jTextField1.setText("exmp:matan");
        jTextField1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTextField1MouseClicked(evt);
            }
        });
        jTextField1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField1ActionPerformed(evt);
            }
        });
        jTextField1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                jTextField1KeyTyped(evt);
            }
        });
        getContentPane().add(jTextField1);
        jTextField1.setBounds(360, 260, 210, 31);

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setText("   password:");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(270, 320, 90, 30);

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setText("username:");
        getContentPane().add(jLabel2);
        jLabel2.setBounds(280, 260, 80, 30);

        jPasswordField1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jPasswordField1MouseClicked(evt);
            }
        });
        jPasswordField1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jPasswordField1ActionPerformed(evt);
            }
        });
        jPasswordField1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                jPasswordField1KeyTyped(evt);
            }
        });
        getContentPane().add(jPasswordField1);
        jPasswordField1.setBounds(360, 320, 210, 30);

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 51, 51));
        jLabel3.setText("Wrong password or username");
        getContentPane().add(jLabel3);
        jLabel3.setBounds(360, 360, 210, 30);

        Projeck_label.setFont(new java.awt.Font("Comic Sans MS", 1, 14)); // NOI18N
        Projeck_label.setIcon(new javax.swing.ImageIcon(getClass().getResource("/project_logo_gif_1.gif"))); // NOI18N
        getContentPane().add(Projeck_label);
        Projeck_label.setBounds(0, 0, 800, 100);

        jLabel4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/pillersWithSky.jpg"))); // NOI18N
        getContentPane().add(jLabel4);
        jLabel4.setBounds(0, -70, 950, 740);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jTextField1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField1ActionPerformed
     String Username=jTextField1.getText();
     String Password=jPasswordField1.getText();
      Login_Details AccountChack = new  Login_Details();
      boolean WindowCloseFlag=AccountChack.Varify_Login(Username, Password);
      if(WindowCloseFlag)
      {
          
        setVisible(false);
      }
      else
      {
          jLabel3.setVisible(true);
      }
    }//GEN-LAST:event_jTextField1ActionPerformed
    boolean inputflag= true;//flag to stop mouse click from clearing text every click
    private void jTextField1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTextField1MouseClicked
    // Does something where mouseclikc on text field
   
    if(inputflag){
        inputflag = false;
    System.out.println("text cleared");
    jTextField1.setText("");//clears text field 
    jTextField1.setForeground(Color.black);
    jTextField1.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent e) {
    
    }
});
    
    }
    }//GEN-LAST:event_jTextField1MouseClicked

    private void jTextField1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jTextField1KeyTyped
       if(inputflag){
        inputflag = false;
    System.out.println("text cleared");
    jTextField1.setText("");//clears text field 
    jTextField1.setForeground(Color.black);
    jTextField1.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent e) {
    String id= "";
    
    }
});
    
    }
    }//GEN-LAST:event_jTextField1KeyTyped
   boolean inputflag2= true;//flag to stop mouse click from clearing text every click on the second field
    private void jPasswordField1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jPasswordField1ActionPerformed
           String Username=jTextField1.getText();
     String Password=jPasswordField1.getText();
      Login_Details AccountChack = new  Login_Details();
      boolean WindowCloseFlag=AccountChack.Varify_Login(Username, Password);
      if(WindowCloseFlag)
      {
          
        setVisible(false);
      }
       else
      {
          jLabel3.setVisible(true);
      }
      
    }//GEN-LAST:event_jPasswordField1ActionPerformed

    private void jPasswordField1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jPasswordField1MouseClicked
        
    if(inputflag2){
        inputflag2 = false;
    System.out.print("text cleared");
    jPasswordField1.setText("");//clears text field 
    jPasswordField1.setForeground(Color.black);
    jPasswordField1.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent e) {
    
    }
});
    
    }
    }//GEN-LAST:event_jPasswordField1MouseClicked

    private void jPasswordField1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jPasswordField1KeyTyped
         if(inputflag2){
        inputflag2 = false;
    System.out.print("text cleared");
    jPasswordField1.setText("");//clears text field 
    jPasswordField1.setForeground(Color.black);
    jPasswordField1.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent e) {
    
    }
});
    }//GEN-LAST:event_jPasswordField1KeyTyped
    }
    private void jLabel5MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jLabel5MouseClicked
            String Username=jTextField1.getText();
     String Password=jPasswordField1.getText();
      Login_Details AccountChack = new  Login_Details();
      boolean WindowCloseFlag=AccountChack.Varify_Login(Username, Password);
      if(WindowCloseFlag)
      {
          
        setVisible(false);
      }
      else
      {
          jLabel3.setVisible(true);
      }
    }//GEN-LAST:event_jLabel5MouseClicked

    /**
     * @param args the command line arguments
     */
   
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */{
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Login_Screen.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Login_Screen.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Login_Screen.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Login_Screen.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
      
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel Projeck_label;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JPasswordField jPasswordField1;
    private javax.swing.JTextField jTextField1;
    // End of variables declaration//GEN-END:variables
}

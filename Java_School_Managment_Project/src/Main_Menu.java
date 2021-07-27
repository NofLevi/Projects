
import javax.swing.ImageIcon;


public class Main_Menu extends javax.swing.JFrame {


    public Main_Menu() {
        initComponents();
         setTitle("Main menu");
         ImageIcon icon;
         icon = new ImageIcon("src\\image\\icon.png");
        setIconImage(icon.getImage());
    }


    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        tel_hai_acadamic = new javax.swing.JLabel();
        tel_hai_tech = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setPreferredSize(new java.awt.Dimension(800, 600));
        getContentPane().setLayout(null);

        tel_hai_acadamic.setIcon(new javax.swing.ImageIcon(getClass().getResource("/TELHAI_ACADAMIC.png"))); // NOI18N
        tel_hai_acadamic.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tel_hai_acadamicMouseClicked(evt);
            }
        });
        getContentPane().add(tel_hai_acadamic);
        tel_hai_acadamic.setBounds(50, 390, 300, 126);

        tel_hai_tech.setBackground(new java.awt.Color(255, 255, 255));
        tel_hai_tech.setIcon(new javax.swing.ImageIcon(getClass().getResource("/TELHAI_TECH.png"))); // NOI18N
        tel_hai_tech.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tel_hai_techMouseClicked(evt);
            }
        });
        getContentPane().add(tel_hai_tech);
        tel_hai_tech.setBounds(450, 390, 300, 126);

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/tech_menu_logo.jpg"))); // NOI18N
        getContentPane().add(jLabel1);
        jLabel1.setBounds(398, 0, 410, 600);

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/hippy_logo_menu.png"))); // NOI18N
        getContentPane().add(jLabel2);
        jLabel2.setBounds(0, 0, 400, 600);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void tel_hai_acadamicMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tel_hai_acadamicMouseClicked
         java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Telhai_academic_menu().setVisible(true);
            }
        });//opens the academic menu to select students or teachers
         setVisible(false);
    }//GEN-LAST:event_tel_hai_acadamicMouseClicked

    private void tel_hai_techMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tel_hai_techMouseClicked
           java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Telhai_tech_menu().setVisible(true);
            }
        });//opens the tech menu to select students or teachers
           setVisible(false);
    }//GEN-LAST:event_tel_hai_techMouseClicked

    /**
     * @param args the command line arguments
     */


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel tel_hai_acadamic;
    private javax.swing.JLabel tel_hai_tech;
    // End of variables declaration//GEN-END:variables
}

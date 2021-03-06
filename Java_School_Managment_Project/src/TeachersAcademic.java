
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import javax.swing.ImageIcon;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableRowSorter;



public class TeachersAcademic extends tableLoader {
    DateFormat dateFormat = new SimpleDateFormat("MM/dd/YY");
    Date date = new Date();
    Calendar cal = Calendar.getInstance();
    
    
    public TeachersAcademic() {
        initComponents();
        model = (DefaultTableModel) table.getModel();
        setTitle("academic teachers");
        ImageIcon icon;
        icon = new ImageIcon("src\\image\\icon.png");
        setIconImage(icon.getImage());
        professionindex = 2;
        filelocation = "src\\data\\FILE_Teachers_Academic.txt";
        jLabel1.setText(" " + dateFormat.format(date));
        sort();
        loadFile();
        fileToList();
        loadTable();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        table = new javax.swing.JTable();
        SearchLabel = new javax.swing.JLabel();
        ApplyButton = new javax.swing.JButton();
        StopFilteringButton = new javax.swing.JButton();
        SearchField = new javax.swing.JTextField();
        OptionsLabel = new javax.swing.JLabel();
        AddButton = new javax.swing.JButton();
        RemoveButton = new javax.swing.JButton();
        FunctionsLabel = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        DateLabel = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setMaximumSize(new java.awt.Dimension(1000, 800));
        setMinimumSize(new java.awt.Dimension(1000, 800));
        setPreferredSize(new java.awt.Dimension(1000, 800));
        setResizable(false);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
        });
        getContentPane().setLayout(null);

        table.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "ID", "Name", "Last Name", "Age", "Gender", "Phone", "Profession", "Email", "Year"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }
        });
        jScrollPane1.setViewportView(table);

        getContentPane().add(jScrollPane1);
        jScrollPane1.setBounds(0, 303, 957, 265);

        SearchLabel.setText("Search a teacher:");
        getContentPane().add(SearchLabel);
        SearchLabel.setBounds(540, 250, 110, 45);

        ApplyButton.setText("Apply");
        ApplyButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ApplyButtonActionPerformed(evt);
            }
        });
        getContentPane().add(ApplyButton);
        ApplyButton.setBounds(750, 260, 59, 23);

        StopFilteringButton.setText("Stop Filtering");
        StopFilteringButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                StopFilteringButtonActionPerformed(evt);
            }
        });
        getContentPane().add(StopFilteringButton);
        StopFilteringButton.setBounds(830, 260, 120, 23);

        SearchField.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                SearchFieldActionPerformed(evt);
            }
        });
        getContentPane().add(SearchField);
        SearchField.setBounds(630, 260, 110, 20);

        OptionsLabel.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        OptionsLabel.setText("Options:");
        getContentPane().add(OptionsLabel);
        OptionsLabel.setBounds(0, 190, 67, 35);

        AddButton.setText("Add");
        AddButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                AddButtonActionPerformed(evt);
            }
        });
        getContentPane().add(AddButton);
        AddButton.setBounds(20, 260, 90, 30);

        RemoveButton.setText("Remove");
        RemoveButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                RemoveButtonActionPerformed(evt);
            }
        });
        getContentPane().add(RemoveButton);
        RemoveButton.setBounds(140, 260, 110, 30);

        FunctionsLabel.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        FunctionsLabel.setText("Teachers Functions");
        getContentPane().add(FunctionsLabel);
        FunctionsLabel.setBounds(0, 230, 160, 20);

        jLabel3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/home_icon.png"))); // NOI18N
        jLabel3.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jLabel3MouseClicked(evt);
            }
        });
        getContentPane().add(jLabel3);
        jLabel3.setBounds(890, 40, 80, 80);

        DateLabel.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        DateLabel.setText("Date:");
        getContentPane().add(DateLabel);
        DateLabel.setBounds(780, 10, 60, 30);

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setText("test");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(820, 10, 110, 30);

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/acadamic_list_background.png"))); // NOI18N
        jLabel2.setText("jLabel2");
        getContentPane().add(jLabel2);
        jLabel2.setBounds(0, 0, 1000, 800);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void sort(){
        TableRowSorter<DefaultTableModel> sorter = new TableRowSorter<DefaultTableModel>(model);
        table.setRowSorter(sorter);
    }
    
    private void ApplyButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ApplyButtonActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_ApplyButtonActionPerformed

    private void StopFilteringButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_StopFilteringButtonActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_StopFilteringButtonActionPerformed

    private void SearchFieldActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_SearchFieldActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_SearchFieldActionPerformed

    private void AddButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_AddButtonActionPerformed
                java.awt.EventQueue.invokeLater(new Runnable() {
                    public void run() {
                    new AddFunction(list,model,table,filelocation,professionindex).setVisible(true);
                    }
                });
    }//GEN-LAST:event_AddButtonActionPerformed

    private void RemoveButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_RemoveButtonActionPerformed
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new RemoveFunction(list,model,table,filelocation).setVisible(true);
            }
        });
    }//GEN-LAST:event_RemoveButtonActionPerformed

    private void formWindowClosing(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosing


    }//GEN-LAST:event_formWindowClosing

    private void jLabel3MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jLabel3MouseClicked
         new Main_Menu().setVisible(true);
        setVisible(false);
    }//GEN-LAST:event_jLabel3MouseClicked


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton AddButton;
    private javax.swing.JButton ApplyButton;
    private javax.swing.JLabel DateLabel;
    private javax.swing.JLabel FunctionsLabel;
    private javax.swing.JLabel OptionsLabel;
    private javax.swing.JButton RemoveButton;
    private javax.swing.JTextField SearchField;
    private javax.swing.JLabel SearchLabel;
    private javax.swing.JButton StopFilteringButton;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable table;
    // End of variables declaration//GEN-END:variables
}

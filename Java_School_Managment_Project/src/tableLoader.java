
import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;
import javax.swing.table.DefaultTableModel;



abstract class tableLoader extends javax.swing.JFrame{
    int professionindex;
    Scanner scan = new Scanner(System.in);
    String filelocation;
    ArrayList<Person> list = new ArrayList<>();
    DefaultTableModel model;
    
    
        public void loadFile(){
            try { // converting file to list [WORKING]
               scan = new Scanner(new File(filelocation));
               } catch (FileNotFoundException ex) {
                 System.out.println("Error 404: File Not Found");
            }
        }
        

        public void fileToList(){
            while(scan.hasNext()){
                String id = scan.next();
                String firstname = scan.next();
                String lastname = scan.next();
                String age = scan.next();
                String gender = scan.next();
                String phone = scan.next();
                String profession = scan.next();
                String email = scan.next();
                String yearsoflearning = scan.next();
            Person person = new Person(id,firstname,lastname,age,gender,phone,profession,email,yearsoflearning);
            list.add(person);
            }           
        }
        
        public void loadTable(){
            for(int i = 0; i < list.size();i++){// taking the information from the list and push it into the table
                model.insertRow(model.getRowCount(), new Object[]{
                list.get(i).getId(),
                list.get(i).getFirstname(),
                list.get(i).getLastname(),
                list.get(i).getAge(),
                list.get(i).getGender(),
                list.get(i).getPhone(),
                list.get(i).getProfession(),
                list.get(i).getEmail(),
                list.get(i).getYearsoflearning()
            });
            }
        }
}

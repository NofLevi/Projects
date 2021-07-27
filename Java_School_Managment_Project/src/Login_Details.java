
public class Login_Details {
    String Username = "matan";
    String Password = "100";
    
    public Login_Details(String _Username,String _Password)
    {
        Username = _Username;
        Password = _Password;
    }

    Login_Details() {
      
    }
    public String gettUsername(){return Username;}
    public String gettPassword(){return Password;}
    public void setUsername(String _Username){Username=_Username;}
    public void setPassword(String _Password){Password=_Password;}
    
    public boolean Varify_Login(String _Username,String _Password)
    {
        if(_Username.equals(Username)&&_Password.equals(Password))
        {
            System.out.println("where in boys");
              java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Main_Menu().setVisible(true);
            }
            
        });
           return true;   
            
        }
       System.out.println("user:"+_Username);
       System.out.println("pass:"+_Password);
         System.out.println("misson fail ,will get em' next time");
        return false;
    }
    
    
    
}

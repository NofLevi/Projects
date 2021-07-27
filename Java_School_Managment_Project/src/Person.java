

public class Person {
    
    private String _id;
    private String _firstname;
    private String _lastname;
    private String _age;
    private String _gender;
    private String _email;
    private String _yearsoflearning;
    private String _profession;
    private String _phone;
    
    public Person(String id,String firstname,String lastname,String age,String gender,String phone,String profession,String email,String yearsoflearning){
        _id = id;
        _firstname = firstname;
        _lastname = lastname;
        _age = age;
        _gender = gender;
        _email = email;
        _yearsoflearning = yearsoflearning;
        _profession = profession;
        _phone = phone;
    } 
    
    public Person(Person temp){
        _id = temp.getId();
        _firstname = temp.getFirstname();
        _lastname = temp.getLastname();
        _age = temp.getAge();
        _gender = temp.getGender();
        _phone = temp.getEmail();
        _profession = temp.getYearsoflearning();
        _email = temp.getProfession();
        _yearsoflearning = temp.getPhone();
    }
    
    
    
    //SETTERS UND GETTERS
    public String getId() {return _id;}

    public void setId(String id) {_id = id;}

    public String getFirstname() {return _firstname;}

 
    public void setFirstname(String firstname) {_firstname = firstname;}

    public String getLastname() {return _lastname;}

    public void setLastname(String lastname) {_lastname = lastname;}

    public String getAge() {return _age;}

    public void setAge(String age) {_age = age;}


    public String getGender() {return _gender;}


    public void setGender(String gender) {_gender = gender;}


    public String getEmail() {return _email;}


    public void setEmail(String email) {_email = email;}
    
    public String getYearsoflearning() {return _yearsoflearning;}


    public void setYearsoflearning(String yearsoflearning) {_yearsoflearning = yearsoflearning;}


    public String getProfession() {return _profession;}


    public void setProfession(String Profession) {_profession = Profession;}
    
    public String getPhone() {return _phone;}
    
    public void setPhone(String phone) {_phone = phone;}
    
    
}

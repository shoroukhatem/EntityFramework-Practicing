using EF_CORE_Project.AirLines;
using EF_CORE_Project.Context;
using EF_CORE_Project.Hospital;
using EF_CORE_Project.ITI;
using EF_CORE_Project.Music;
using EF_CORE_Project.Sales;

namespace EF_CORE_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Musician
            using (MusicianDbContext context = new MusicianDbContext())
            {

                //CREATE
                //Musician musician = new Musician
                //{
                //    Name= "Amr Diab",
                //    Ph_Number="0111559964",
                //    City = "Cairo",
                //    Street = "Abbas El Akkad"
                //};
                //Instrument instrument = new Instrument { Name = "OOD", Key = "Du" };
                //context.Instruments.Add(instrument);
                //context.Add(musician);
                //context.SaveChanges();

                // Retreive ,Update,Delete

                //var Musician = context.Musicians.Where(x=>x.Id == 1).FirstOrDefault();
                //if(Musician != null)
                //{
                //    Console.WriteLine($"{Musician.Name} is Found");
                //    Musician.Name = "Shereen";
                //    context.SaveChanges();
                //    context.Remove(Musician);
                //}
                //var song  =  context.Song.Where(x=>x.Author=="Amr Hassan").FirstOrDefault();
                //if(song != null)
                //{
                //    Console.WriteLine($"{song.Title} is Found");
                //    song.Author= "Ali Ali";
                //    context.SaveChanges();
                //    context.Remove(song);
                //}
            }
            #endregion
            #region Hospital
            using (HospitalDbContext context = new HospitalDbContext())
            {
                //create
                //Consultant consultant = new Consultant
                //{
                //    Name = "Ali"
                //};
                //Nurse nurse = new Nurse { 
                //Name = "Aya",
                //Address = "Cairo",
                //Ward_Id = 2
                //};
                //Ward ward = new Ward { 
                //Name = "W1",
                //Nurse_Num = 3
                //};
                //context.Consultants.Add(consultant);
                // context.Wards.Add(ward);
                //context.Nurses.Add(nurse);
                //context.SaveChanges();

                //Retreive ,Update,Delete

            //    var Consultant = context.Consultants.Where(x=>x.Id == 1).FirstOrDefault();
            //    if(Consultant != null)
            //    {
            //        Consultant.Name = "John";
            //        context.SaveChanges();
            //        context.Remove(Consultant);
            //    }
            //    var Nurse = context.Nurses.Where(x => x.Number== 4).FirstOrDefault();
            //    if(Nurse != null)
            //    {
            //        Nurse.Address = "Alex";
            //        context.SaveChanges();
            //        context.Remove(Nurse);
            //    }
            }

            #endregion
            #region AirLines
            using (AirLinesDbContext context = new AirLinesDbContext())
            {
                //Create
                //AirLine airLine = new AirLine { 
                //Name="EgyptAir",
                //Address = "Egypt",
                //Cont_Person = "Ali Ali"
                //};

                //Aircraft aircraft = new Aircraft { 
                //AL_ID = 1,
                //Model = "Airbus",
                //MajPilot="Maher",
                //Assistant = "Sami",
                //Host1 = "Aliaa",
                //Host2 = "Aya",
                //Capacity = 120,
                //};
                //context.AirLines.Add(airLine);
                // context.Aircrafts.Add(aircraft);

                //context.SaveChanges();

                //Retreive ,Update,Delete
                //var aircraft = context.Aircrafts.Where(x=>x.Id == 1).FirstOrDefault();
                //if (aircraft != null)
                //{
                //    aircraft.MajPilot = "Ahmed";
                //    context.SaveChanges();
                //    context.Remove(aircraft);
                //}
            }


            #endregion
            #region Sales
            //using (SalesDbContext context = new SalesDbContext())
            //{
            //    #region Create
            //    //Sales_Office sales_Office = new Sales_Office
            //    //{
            //    //    Location =  "Cairo",
            //    //    EmpId = 1

            //    //};

            //    //Employee employee= new Employee
            //    //{

            //    //     Name = "Hassan",
            //    //     Off_Number = 1

            //    //};
            //    //Owner owner = new Owner { Name ="Ahmed"};
            //    //Property property = new Property { 
            //    //Address = "5 Haram st",
            //    //City ="Giza",
            //    //State = "Giza",
            //    //Code = "2345",
            //    //Off_Number = 1
            //    //};
            //    //Prop_Owner prop_Owner = new Prop_Owner { 
            //    //Own_Id = 1,
            //    //Prop_Id = 1,
            //    //Percent = 50.5
            //    //};
            //    //context.Sales_Offices.Add(sales_Office);
            //    //context.Employees.Add(employee);
            //    //context.Owners.Add(owner);
            //    //context.properties.Add(property);
            //    //context.Prop_Owner.Add(prop_Owner);

            //    // context.SaveChanges();
            //    #endregion
            //    #region Retreive ,Update,Delete
            //    //var employee = context.Employees.Where(x => x.Id == 3).FirstOrDefault();
            //    //if(employee is null)
            //    //{
            //    //    Console.WriteLine("Not Found");
            //    //}
            //    //else
            //    //{
            //    //    //update
            //    //    employee.Name= "Ahmed";
            //    //    context.SaveChanges();
            //    //    //delete
            //    //    context.Employees.Remove(employee);
            //    //    context.SaveChanges();
            //    //}
            //    #endregion
            //}
            #endregion
            #region ITI
            using (ITIDbContext context = new ITIDbContext())
            {
                //Create

                //Student student = new Student
                //{
                //    FName = "Shorouk",
                //    LName = "Hatem",
                //    Address = "Giza",
                //    Age =22,
                //    Dep_Id=8
                //};

                //Department department = new Department {
                //    Name = "DS",
                //    Hiring_Date = DateTime.Now,
                //    Ins_Id = 3,

                //};

                //Instructors instructor = new Instructors { 
                //Name =  "Salem",
                //Address = "Cairo",
                //Salary = 7000,
                //Bouns = 1000,
                //Hour_Rate = 10.3,
                //Dep_Id = 8
                //};

                //Topic topic = new Topic { 
                //Name = "Programming"
                //};

                //Course course = new Course { 
                //Name = "C#",
                //Description = "Programing Language Course",
                //Duration = 12,
                //Top_Id = 1
                //};

                //Course_Instructor course_Instructor = new Course_Instructor { 
                //Course_Id=1,
                //Inst_Id=1,
                //Evaluation=90.5
                //};

                //Student_Course student_Course = new Student_Course { 
                //Stud_Id=1,
                //Course_Id=1,
                //Grade =100
                //};
                //context.Students.Add(student);
                // context.Departments.Add(department);
                //context.Instructors.Add(instructor);
                //context.Add(topic);
                //context.Add(course);
                //context.Add(course_Instructor);
                //context.Add(student_Course);
                //context.SaveChanges();


                //Retreive ,Update,Delete

                //var Student = context.Students.Where(x=>x.Id == 1).FirstOrDefault();
                //var Course = context.Courses.Where(x=>x.Id == 1).FirstOrDefault();
                //var Instructor = context.Instructors.Where(x=>x.Id == 1).FirstOrDefault();
                //var Topic = context.Topics.Where(x=>x.Id == 1).FirstOrDefault();
                //var Department = context.Departments.Where(x=>x.Id == 8).FirstOrDefault();
         
                //if(Student == null)
                //{
                //    Console.WriteLine("Student NOT FOUND");
                //}
                //else
                //{
                //    Console.WriteLine($"{Student.FName} {Student.LName} is Found");
                //    Student.Dep_Id = 11;
                //    context.SaveChanges();
                //    context.Remove(Student);

                //}
                //if (Course == null)
                //{
                //    Console.WriteLine("Course NOT FOUND");
                //}
                //else
                //{
                //    Console.WriteLine($"{Course.Name} is Found");
                //    Course.Name= "C++";
                //    context.SaveChanges();
                //    context.Remove(Course);

                //}

            }
            #endregion
        }
    }
}
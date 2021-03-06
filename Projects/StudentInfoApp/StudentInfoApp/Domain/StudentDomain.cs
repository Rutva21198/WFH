﻿using StudentInfoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StudentInfoApp.Domain
{
    public class StudentDomain : BaseDomain
    {
        public void Add(Student s)
        {
            this.ExecuteQuery($"insert into Students values ('{s.Name}','{s.Mobile}','{s.Email}','{s.Course}',{s.Fees})");
            //this.ExecuteQuery("[dbo].[spInsertStudent]",s);
        }
        public void Update(Student s)
        {
            this.ExecuteQuery($"update Students set Name='{s.Name}',MobileNo='{s.Mobile}',EmailId='{s.Email}',Course='{s.Course}',Fees={s.Fees} where StudentId = {s.Id}");
        }
        public void Delete(int id)
        {
            // this.ExecuteQuery($"delete from Students where StudentId = {id}");
            this.DeleteStudent("[dbo].[spInsertStudent]", id);
        }
    }
}

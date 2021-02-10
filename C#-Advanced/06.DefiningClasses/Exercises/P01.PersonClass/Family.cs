﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
		public Family()
		{
			this.Members = new List<Person>();
		}

		public List<Person> Members { get; set; }

		public void AddMember(Person member)
		{
			this.Members.Add(member);
		}

		public Person GetOldestMember()
		{
			Person oldestPerson = Members.OrderByDescending(m => m.Age).FirstOrDefault();
			return oldestPerson;
		}
	}
}

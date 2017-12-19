using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingReferenceTypesByValue {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("*** Passing Person object by value ***");

			// Create person
			Person fred = new Person("Fred", 23);

			// Display person initially
			Console.WriteLine("\nBefore by value call, Person is:");
			fred.Display();

			// Send the person for adjustment
			SendAPersonByValue(fred);

			// Display new person value
			Console.WriteLine("\nAfter by value call, Person is:");
			fred.Display();

			// Reassign fred's reference
			SendAPersonByReference(ref fred);
			Console.WriteLine("\nAfter passed for reference reassignment, Person is:");
			fred.Display();

			Console.ReadLine();
		}

		static void SendAPersonByValue(Person p) {
			// Change the age of "p"? - Yes, alters reference's value.
			p.personAge = 99;

			// Will the caller see this reassignment? - No! Not possible to reassign what the reference is pointing to.
			p = new Person("Dave", 99);
		}

		static void SendAPersonByReference(ref Person p) {
			// Change data in p
			p.personAge = 555;

			// "p" is now pointing to a new object in the heap.
			p = new Person("Kieron", 999);
		}
	}

	class Person {
		public string personName;
		public int personAge;

		// Constructors
		public Person(string name, int age) {
			personName = name;
			personAge = age;
		}
		public Person() { }

		public void Display() {
			Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
		}

	}
}

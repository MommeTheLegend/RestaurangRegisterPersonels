using System;
using System.Collections;

public class PersonelRegister
{
	private List<Personel> employees = new List<Personel>();
	private int count = 0;
	
	public PersonelRegister(Personel aEmployee)
	{ 
		employees.Add(aEmployee);
		count++;
	}  

	public void hireEmployee(Personel newEmployee)
	{
		employees.Add(newEmployee); 
		count++;
	} 

	public void fireEmployee(Personel notDesiredEmployer)
	{
		if (count > 0)
		{
            employees.Remove(notDesiredEmployer);
            count--;
        }
        else
        {
			Console.WriteLine("Unfortunatelly, you have fired employee in your company!");
        }
    } 
	public int totalAmountOfHiredEmployees()
	{
		return employees.Count;
	} 
	
	public void GetAllPersonel()
	{
		int numberOfPersonal = 0;
		foreach (Personel personel in employees)
		{
			Console.Write("Your {0} employee ", numberOfPersonal);
			Console.WriteLine(personel.ToString()); 
			Console.WriteLine(personel);
			numberOfPersonal++; 
		}
	}
}

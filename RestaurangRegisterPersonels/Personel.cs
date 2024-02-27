using System;

public class Personel
{
	private string name;
	private int salary; 
	
	public Personel(string aName, int aSalary )
	{  
		this.name = aName; 
		this.salary = aSalary;
	} 

	public void setSalary(int salary)
	{
		this.salary = salary;
	} 
	public int getSalary()
	{
		return this.salary;
	}  
	public void changeName(string name) 
	{ 
		this.name = name;
	}  
	public void changeSalary(int amount)
	{
		this.salary += amount;
	}
	public string getName()
	{
		return this.name;
	}
}

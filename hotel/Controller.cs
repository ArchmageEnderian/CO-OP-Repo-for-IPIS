using System;

public class Controller
{
	private Controller(string userName)
	{

	}

	public List<UserModel> Users { get; }

	public UserModel CurrentUser { get; }

	public void Save()
    {

    }

	public void SetNewUserData(string genderName, DateTime birthDate, int passortSeries, int passortNumber, string phoneNumber, int roomNumber, bool withChildren, int amountOfResidents, DateTime arrivalDate, DateTime departureDate)
    {

    }

	private List<UserModel> GetUsersData() // ???
    {

    }



}

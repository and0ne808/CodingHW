#include <iostream>
#include <string>

using namespace std;

//Program Functions
void mainMenu();
int exitApplication();

//Encryption Functions
string Encrypt(string message, int shift);
string Decrypt(string message, int shift);
void bruteForce(string message);

//Input Prompting Functions
int shiftValuePrompt();
string messagePrompt();

//MAIN PROGRAM---------------------------------------------------------------------
int main()
{
	mainMenu();
	return(exitApplication());
}
//END MAIN PROGRAM------------------------------------------------------------------

void mainMenu()
{
	// display welcome message with instructions
	int choice;

	cout << "Please choose an option and press ENTER to proceed..." << endl;
	cout << "1 - Encrypt a message" << endl;
	cout << "2 - Decrypt a message" << endl;
	cout << "3 - Brute-force decrypt a message" << endl;
	cout << "4 - Quit" << endl;

	//Check for validity of entry
	cin >> choice;
	while (!(choice > 0 && choice < 5))
	{
		cout << "Please enter an integer between 1 and 4 only" << endl;
		cin >> choice;
	}

	//Get choice from user
	switch (choice) {
	case 1:
		cout << Encrypt(messagePrompt(), shiftValuePrompt()) << endl;
		mainMenu();
		break;
	case 2:
		cout << Decrypt(messagePrompt(), shiftValuePrompt()) << endl;
		mainMenu();
		break;
	case 3:
		bruteForce(messagePrompt());
		mainMenu();
		break;
	case 4:
		break;
	default:
		break;
	}
	
}

int exitApplication()
{
	char a;
	cout << "Please enter any character and press ENTER to exit..." << endl;
	cin >> a;
	return 0;
}

int shiftValuePrompt()
{
	int shiftValue;
	cout << "Please enter a shift value between 1 and 26" << endl;
	cin >> shiftValue;
	while (shiftValue < 1 || shiftValue > 26)
	{
		cout << "Please only enter an integer between 1 and 26" << endl;
		cin >> shiftValue;
	}
	return shiftValue;
}

string messagePrompt()
{
	cin.clear();
	string messageInput;
	getline(cin, messageInput);
	while(messageInput.length() < 1)
	{
		cout << "Please enter a string of characters to process" << endl;
		getline(cin, messageInput);
	}
	return messageInput;
}

//My encryption algorithm
string Encrypt(string message, int shift)
{
	int numberOfCharacters = message.length();
	string encrypted = message;
	for (int i = 0; i < message.length(); i++)
	{
		if (message[i] <= 'z' && message[i] >= 'a')
		{
			encrypted[i] = (char)(message[i] + shift);
			while (encrypted[i] > 'z')
			{
				encrypted[i] = encrypted[i] - 26;
			}
			while (encrypted[i] < 'a')
			{
				encrypted[i] = encrypted[i] + 26;
			}
		}
		else if (message[i] <= 'Z' && message[i] >= 'A')
		{
			encrypted[i] = (char)(message[i] + shift);
			while (encrypted[i] > 'Z')
			{
				encrypted[i] = encrypted[i] - 26;
			}
			while (encrypted[i] < 'A')
			{
				encrypted[i] = encrypted[i] + 26;
			}
		}
	}

	return encrypted;
}

//My decryption algorithm
string Decrypt(string message, int shift)
{
	int numberOfCharacters = message.length();
	string encrypted = message;
	for (int i = 0; i < message.length(); i++)
	{
		if (message[i] <= 'z' && message[i] >= 'a')
		{
			encrypted[i] = (char)(message[i] - shift);
			while (encrypted[i] > 'z')
			{
				encrypted[i] = encrypted[i] - 26;
			}
			while (encrypted[i] < 'a')
			{
				encrypted[i] = encrypted[i] + 26;
			}
		}
		else if (message[i] <= 'Z' && message[i] >= 'A')
		{
			encrypted[i] = (char)(message[i] - shift);
			while (encrypted[i] > 'Z')
			{
				encrypted[i] = encrypted[i] - 26;
			}
			while (encrypted[i] < 'A')
			{
				encrypted[i] = encrypted[i] + 26;
			}
		}
	}

	return encrypted;
}

//My brute force decryption algorithm
void bruteForce(string message)
{
	for (int x = 1; x < 26; x++)
	{
		cout << Decrypt(message, x) << endl;
	}
}
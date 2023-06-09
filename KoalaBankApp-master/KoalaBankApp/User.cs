﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KoalaBankApp
{
    public class User
    {
        private string _UserName;
        private string _PassWord;
        private string _FirstName;
        private string _LastName;
        private string _Email;
        private List<BankAccount> _BankAccountList;
        private List<SavingsAccount> _SavingsAccountList;
        private List<Transactions> _UserTransactionsList;
        private bool _IsAdmin;

        public User(string username = "Default Username", string password = "password123", string firstname = "Default First Name", string lastname = "Default Last Name", string email = "Default@Email.com",
            List<BankAccount> bankAccountList = null, List<SavingsAccount> savingsAccountList = null, List<Transactions> userTransactionsList = null, bool isAdmin = false)
        {
            this._UserName = username;
            this._PassWord = password;
            this._FirstName = firstname;
            this._LastName = lastname;
            this._Email = email;
            this._BankAccountList = bankAccountList;
            this._SavingsAccountList = savingsAccountList;
            this._UserTransactionsList = userTransactionsList;
            this._IsAdmin = isAdmin;
        }
        public string Username
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string Password
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }
        public string Firstname
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string Lastname
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public List<BankAccount> BankAccountList
        {
            get { return _BankAccountList; }
            set { _BankAccountList = value; }
        }
        public List<SavingsAccount> SavingsAccountList
        {
            get { return _SavingsAccountList; }
            set { _SavingsAccountList = value; }
        }
        public List<Transactions> UserTransactionsList
        {
            get { return _UserTransactionsList; }
            set { _UserTransactionsList = value; }
        }
        public bool IsAdmin
        {
            get { return _IsAdmin; }
            set { _IsAdmin = value; }
        }
        public void PrintAllUsers(List<User> accounts, User activeUser, CurrencyRates objRates)
        {
            Console.Clear();
            int i = 1;
            foreach (var item in accounts)
            {
                Console.WriteLine("{0}. {1}", i, item.Username);
                i++;
            }
            Console.ReadKey();
            Login back = new Login();
            //back.loginAdmin(accounts, activeUser, objRates);
        }
        public List<User> CreateUser(List<User> accounts, bool isadmin, User activeUser, CurrencyRates rates)
        {
            //Console.Clear();
            //if (isadmin == true)
            //{
            //Console.Clear();
            //bool checkUsers = false;
            //string username = string.Empty;
            //string userInput = string.Empty;
            //do
            //{
            //    //Console.Clear();
            //    Console.WriteLine("Please enter information for the new user.");
            //    Console.Write("Choose a username: ");
            //    userInput = Console.ReadLine();
            //    checkUsers = accounts.Exists(cu => cu.Username == userInput);

            //    if (checkUsers == true)
            //    {
            //        Console.WriteLine("Username already exists, please choose another one.");
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        username = userInput;
            //    }
            //} while (checkUsers == true);

            //Console.Write("Choose a password: ");
            //string password = Console.ReadLine();
            //Console.Write("What is the first name: ");
            //string firstName = Console.ReadLine().ToLower();
            //Console.Write("What is the last name: ");
            //string lastName = Console.ReadLine().ToLower();
            //Console.Write("Email Adress: ");
            //string email = Console.ReadLine().ToLower();

            //string userAdmin = string.Empty;
            //bool isAdmin = false;
            //do
            //{
            //    //Console.Clear();
            //    Console.WriteLine("Should this user be Administrator? (Yes/No):");
            //    userAdmin = Console.ReadLine().ToLower();

            //    if (userAdmin == "yes")
            //    {
            //        isAdmin = true;
            //        break;
            //    }
            //    else if (userAdmin == "no")
            //    {
            //        isAdmin = false;
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please write YES or NO.");
            //        Console.ReadKey();
            //        continue;
            //    }
            //} while (true);
                string username = "";
                string password = "";
                string firstName = "";
                string lastName = "";
                string email = "";
                bool isAdmin = false;


                List<BankAccount> newBankAcc = new List<BankAccount>();
                List<SavingsAccount> newSavingsAcc = new List<SavingsAccount>();
                List<Transactions> newTransactionsList = new List<Transactions>();
                BankAccount newAcc = new BankAccount("Private Account", 0, "SEK");
                User newAccount = new User(username, password, firstName, lastName, email, newBankAcc, newSavingsAcc, newTransactionsList, isAdmin);
                newAccount.BankAccountList.Add(newAcc);
                accounts.Add(newAccount);

                //Login back = new Login();
                //back.loginAdmin(accounts, activeUser, rates);

                return accounts;
            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine("You are not Admin.");
            //    Console.WriteLine("Press any key to continue . . .");
            //    Console.ReadKey();
            //    return null;
            //}
        }
        public void PrintAccountInfo(User activeUser, CurrencyRates rates)
        {
            Console.Clear();
            Console.WriteLine("Username: {0}", activeUser.Username);
            Console.WriteLine("Full Name: {0} {1}", activeUser.Firstname, activeUser.Lastname);
            Console.WriteLine("Email Adress: {0}", activeUser.Email);
            Console.WriteLine();

            BankAccount.PrintAccounts(activeUser, rates);

            Console.ReadKey();
        }
    }
}

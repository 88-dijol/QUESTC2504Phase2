using System;
using BankingProject;
using System.Security.Principal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BankingProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        private AccountMemoryRepo _repo;
        [TestInitialize]
        public void initialize()
        {
            _repo = AccountMemoryRepo.Instance;
        }
        [TestMethod]

        public void Test_ReadAllAccount()
        {
            _repo = AccountMemoryRepo.Instance;
            var accounts = _repo.ReadAllAccount();

            //Assert.AreEqual(2, accounts.Count);
            Assert.IsTrue(accounts.Any(a => a.AccNo == 123));
            Assert.IsTrue(accounts.Any(a => a.AccNo == 124));
        }

        [TestMethod]
        public void Test_CreateAccount()
        {
            var account = new AccountModel()
            {
                AccNo = 123,
                Name = "Dinoy",
                Balance = 0,
                AccType = "savings",
                Email = "dinoy@gmail.com",
                PhoneNumber = "5236526526",
                Address = "mulakkampilly",
                IsActive = true,
                InterestPercentage = "0",
                TransactionCount = 0,
                LastTransactionDate = DateTime.Now,
            };
            _repo.Create(account);

            Assert.IsTrue(_repo.ReadAllAccount().Any(ac => ac.AccNo == 123));
        }

        [TestMethod]
        public void Test_UpdateAccount()
        {
            AccountModel account = new AccountModel
            {

                AccNo = 124,
                Name = "Davis",
                Balance = 0,
                AccType = "current",
                Email = "davis@gmail.com",
                PhoneNumber = "5236526526",
                Address = "tharayil",
                IsActive = true,
                InterestPercentage = "0",
                TransactionCount = 0,
                LastTransactionDate = DateTime.Now,
            };

            account.Address = "New Address";
            _repo.UpdateAccount(account);
            Assert.AreEqual("New Address", _repo.ReadAllAccount().First(a => a.AccNo == 124).Address);
        }
        [TestMethod]
        public void Test_Deposit()
        {
            AccountModel account = new AccountModel
            {
                AccNo = 123,
                Name = "Dinoy",
                Balance = 0,
                AccType = "savings",
                Email = "dinoy@gmail.com",
                PhoneNumber = "5236526526",
                Address = "mulakkampilly",
                IsActive = true,
                InterestPercentage = "0",
                TransactionCount = 0,
                LastTransactionDate = DateTime.Now,
            };

            _repo.Deposit(account.AccNo, 1000);
            Assert.AreEqual(1000, _repo.ReadAllAccount().First(ac => ac.AccNo == account.AccNo).Balance);
        }

        [TestMethod]
        public void Test_Withdraw()
        {
            var account = new AccountModel()
            {

                AccNo = 124,
                Name = "Davis",
                Balance = 0,
                AccType = "current",
                Email = "davis@gmail.com",
                PhoneNumber = "5236526526",
                Address = "tharayil",
                IsActive = true,
                InterestPercentage = "0",
                TransactionCount = 0,
                LastTransactionDate = DateTime.Now,
            };

            _repo.Deposit(account.AccNo, 1000);
            _repo.Withdrw(account.AccNo, 700);
            Assert.AreEqual(300, _repo.ReadAllAccount().First(ac => ac.AccNo == account.AccNo).Balance);

        }

    }
}


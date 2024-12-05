using System;

namespace HomeWork6_Tymakov
{
    enum AccountType
    {
        currentAccount,
        savingAccount,
    }

    internal class BankAccount
    {
        private static uint accountIdCounter = 1;
        private readonly uint accountId;
        private decimal balance;
        private readonly AccountType accountType;

        /// <summary>
        /// Принимает баланс и тип аккаунта
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="accountType"></param>
        public BankAccount(decimal balance, AccountType accountType)
        {
            accountId = SetCurrentId();
            this.balance = balance;
            this.accountType = accountType;
        }

        /// <summary>
        /// Вычитает из баланса вводимое число
        /// </summary>
        /// <param name="amount"></param>
        public void WithdrawMoney(decimal amount)
        {
            if (balance - amount >= 0 && amount > 0)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств или некорректная сумма для снятия.");
            }
            return;
        }

        /// <summary>
        /// Прибовляет к балансу вводимое число
        /// </summary>
        /// <param name="amount"></param>
        public void DepositMoney(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Сумма для пополнения должна быть положительной.");
            }
        }

        private static uint SetCurrentId()
        {
            return accountIdCounter++;
        }
        public void GetAccountData()
        {
            Console.WriteLine($"ID: {string.Format("{0:D7}", accountId)}\nБаланс: {balance}\nТип аккаунта: {accountType}\n");
        }
    }
}

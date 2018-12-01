CREATE SCHEMA MoneyManager;
USE MoneyManager;

/* Account_Type */
CREATE TABLE Account_Type (
 idAccount_Type INT NOT NULL AUTO_INCREMENT,
 nameAccount_Type VARCHAR(100) NOT NULL,
 
 PRIMARY KEY (idAccount_Type)
);

/* Account */
CREATE TABLE Account (
 idAccount INT NOT NULL AUTO_INCREMENT,
 nameAccount VARCHAR(100) NOT NULL,
 balanceAccount DOUBLE(9,2) DEFAULT 0,
 memoAccount VARCHAR(100),
 accountType INT NOT NULL,
 
 PRIMARY KEY (idAccount),
 FOREIGN KEY (accountType) REFERENCES Account_Type(idAccount_Type)
);

/* Income_Category */
CREATE TABLE Income_Category (
 idCategory INT NOT NULL AUTO_INCREMENT,
 nameCategory VARCHAR(100) NOT NULL,
 
 PRIMARY KEY (idCategory)
);

/* Income */
CREATE TABLE Income (
 idIncome INT NOT NULL AUTO_INCREMENT,
 accountIncome INT NOT NULL,
 categoryIncome INT NOT NULL,
 amountIncome DOUBLE(9,2) NOT NULL,
 memoIncome VARCHAR(200) DEFAULT '',
 dateIncome DATE NOT NULL,
 
 PRIMARY KEY (idIncome),
 FOREIGN KEY (accountIncome) REFERENCES Account(idAccount),
 FOREIGN KEY (categoryIncome) REFERENCES Income_Category(idCategory)
);

/* Expense_Category */
CREATE TABLE Expense_Category (
 idCategory INT NOT NULL AUTO_INCREMENT,
 nameCategory VARCHAR(100) NOT NULL,
 
 PRIMARY KEY (idCategory)
);

/* Expense */
CREATE TABLE Expense (
 idExpense INT NOT NULL AUTO_INCREMENT,
 accountExpense INT NOT NULL,
 categoryExpense INT NOT NULL,
 amountExpense DOUBLE(9,2) NOT NULL,
 memoExpense VARCHAR(200) DEFAULT '',
 dateExpense DATE NOT NULL,
 
 PRIMARY KEY (idExpense),
 FOREIGN KEY (accountExpense) REFERENCES Account(idAccount),
 FOREIGN KEY (categoryExpense) REFERENCES Expense_Category(idCategory)
);

/* Transfer */
CREATE TABLE Transfer (
 idTransfer INT NOT NULL AUTO_INCREMENT,
 fromAccountTransfer INT NOT NULL,
 toAccountTransfer INT NOT NULL,
 amountTransfer DOUBLE(9,2) NOT NULL,
 dateTransfer DATE NOT NULL,
 memoTransfer VARCHAR(100) DEFAULT '',
 
 PRIMARY KEY (idTransfer),
 FOREIGN KEY (fromAccountTransfer) REFERENCES Account(idAccount),
 FOREIGN KEY (toAccountTransfer) REFERENCES Account(idAccount)
);

/* Transfer_Fee */
CREATE TABLE Transfer_Fee (
 idTransfer_Fee INT NOT NULL,
 amountTransfer_Fee DOUBLE(9,2) NOT NULL,
 
 FOREIGN KEY (idTransfer_Fee) REFERENCES Transfer (idTransfer)
);


/* INSERTS */
/* Standard Account Types */
INSERT INTO Account_Type (
 nameAccount_Type
) VALUES (
 'Cash'
);

INSERT INTO Account_Type (
 nameAccount_Type
) VALUES (
 'Bank Account'
);


/* Standard Income Categories */
INSERT INTO Income_Category (
 nameCategory
) VALUES (
 'Salary'
);

INSERT INTO Income_Category (
 nameCategory
) VALUES (
 'Bonus'
);

INSERT INTO Income_Category (
 nameCategory
) VALUES (
 'Other'
);


/* Standard Expense Categories */
INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Food'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Bill'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Social Life'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Self-development'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Transportation'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Household'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Apparel'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Beauty'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Health'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Education'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Gift'
);

INSERT INTO Expense_Category (
 nameCategory
) VALUES (
 'Other'
);


/* SELECTS */
SELECT * FROM Account_Type;
SELECT * FROM Account;

SELECT * FROM Income_Category;
SELECT * FROM Income;

SELECT * FROM Expense_Category;
SELECT * FROM Expense;

SELECT * FROM Transfer;
SELECT * FROM Transfer_fee;
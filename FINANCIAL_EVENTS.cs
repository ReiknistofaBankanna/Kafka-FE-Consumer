// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.4
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace @value.SOURCEDB.BANKING
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	public partial class FINANCIAL_EVENTS : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse("{\"type\":\"record\",\"name\":\"FINANCIAL_EVENTS\",\"namespace\":\"value.SOURCEDB.BANKING\",\"" +
				"fields\":[{\"name\":\"EVENT_ID\",\"default\":0,\"type\":\"long\"},{\"name\":\"YEAR\",\"default\":" +
				"0,\"type\":\"int\"},{\"name\":\"DATA_OWNER\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"BANK" +
				"\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"AGREEMENT_ID\",\"default\":\"\",\"type\":\"stri" +
				"ng\"},{\"name\":\"ENTRY_DATE\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"VALUE_DATE\",\"de" +
				"fault\":\"\",\"type\":\"string\"},{\"name\":\"AMOUNT\",\"default\":\"0\",\"type\":\"string\"},{\"nam" +
				"e\":\"BALANCE\",\"default\":\"0\",\"type\":\"string\"},{\"name\":\"CURRENCY_CODE\",\"default\":\"\"" +
				",\"type\":\"string\"},{\"name\":\"LCY_AMOUNT\",\"default\":\"0\",\"type\":\"string\"},{\"name\":\"T" +
				"RANSACTION_BANK\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"TRANSACTION_CODE\",\"defau" +
				"lt\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"BATCH_NUMBER\",\"default\":\"\",\"type\":[\"st" +
				"ring\",\"null\"]},{\"name\":\"REFERENCE_NUMBER\",\"default\":\"\",\"type\":[\"string\",\"null\"]}" +
				",{\"name\":\"CATEGORY_CODE\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"CATEGOR" +
				"Y\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"OWNER_ID\",\"default\":\"\",\"type\"" +
				":[\"string\",\"null\"]},{\"name\":\"EXTERNAL_REFERENCE\",\"default\":\"\",\"type\":[\"string\",\"" +
				"null\"]},{\"name\":\"EVENT_SOURCE_CODE\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"PAYME" +
				"NT_TYPE\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"TRANSACTION_SEQUENCE_NU" +
				"MBER\",\"default\":0,\"type\":[\"int\",\"null\"]},{\"name\":\"EVENT_GROUP_ID\",\"default\":\"\",\"" +
				"type\":[\"string\",\"null\"]},{\"name\":\"DUE_DATE\",\"default\":\"\",\"type\":[\"string\",\"null\"" +
				"]},{\"name\":\"COUNTERPARTY_ID\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"IS_" +
				"HANDLING_FEE\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"VOID_CODE\",\"default\":\"\",\"ty" +
				"pe\":\"string\"},{\"name\":\"VOID_CODE_DATE\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"" +
				"name\":\"BOOKING_DATE\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"ATM_CODE\",\"default\":" +
				"0,\"type\":[\"int\",\"null\"]},{\"name\":\"MERCHANT_AGREEMENT_NUMBER\",\"default\":0,\"type\":" +
				"[\"int\",\"null\"]},{\"name\":\"CHEQUE_GUARANTEE_NUMBER\",\"default\":0,\"type\":[\"int\",\"nul" +
				"l\"]},{\"name\":\"CREATED_BY\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"CREATE" +
				"D_DATE\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"REFERENCE\",\"default\":\"\"," +
				"\"type\":[\"string\",\"null\"]},{\"name\":\"REFERENCE_DESCRIPTION\",\"default\":\"\",\"type\":[\"" +
				"string\",\"null\"]},{\"name\":\"EXTENDED_REFERENCE\",\"default\":\"\",\"type\":[\"string\",\"nul" +
				"l\"]},{\"name\":\"LOAD_DATE\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"AGREEMENT_PID\",\"" +
				"default\":\"0\",\"type\":[\"string\",\"null\"]},{\"name\":\"COUNTERPARTY_AGREEMENT_ID\",\"defa" +
				"ult\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"COUNTERPARTY_AGREEMENT_PID\",\"default\"" +
				":\"0\",\"type\":[\"string\",\"null\"]},{\"name\":\"COUNTERPARTY_REFERENCE\",\"default\":\"\",\"ty" +
				"pe\":[\"string\",\"null\"]},{\"name\":\"OPERATION_REFERENCE\",\"default\":\"\",\"type\":[\"strin" +
				"g\",\"null\"]},{\"name\":\"EXTERNAL_OPERATION_REFERENCE\",\"default\":\"\",\"type\":[\"string\"" +
				",\"null\"]},{\"name\":\"TRANSACTION_REFERENCE\",\"default\":\"\",\"type\":[\"string\",\"null\"]}" +
				",{\"name\":\"ORDERER_ID\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"ORDERER_NA" +
				"ME\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"BENEFICIARY_ID\",\"default\":\"\"" +
				",\"type\":[\"string\",\"null\"]},{\"name\":\"BENEFICIARY_NAME\",\"default\":\"\",\"type\":[\"stri" +
				"ng\",\"null\"]},{\"name\":\"BATCH_REFERENCE\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"" +
				"name\":\"MERCHANT_NAME\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"CARD_ID\",\"" +
				"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"ORDERER_CROSSRATE\",\"default\":\"0\"," +
				"\"type\":[\"string\",\"null\"]},{\"name\":\"ORDERER_EXCHANGERATE\",\"default\":\"0\",\"type\":[\"" +
				"string\",\"null\"]},{\"name\":\"BENEFICIARY_CROSSRATE\",\"default\":\"0\",\"type\":[\"string\"," +
				"\"null\"]},{\"name\":\"BENEFICIARY_EXCHANGERATE\",\"default\":\"0\",\"type\":[\"string\",\"null" +
				"\"]},{\"name\":\"CARD_NUMBER_MASKED\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":" +
				"\"EXTERNAL_USER\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"PAYMENT_PURPOSE_" +
				"CODE\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"OPERATION_TYPE\",\"default\":" +
				"\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"TELLER_ID\",\"default\":\"\",\"type\":[\"string\",\"" +
				"null\"]},{\"name\":\"ENTITY\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"STANDAR" +
				"D_DESCRIPTION\",\"default\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"CHANNEL_CODE\",\"de" +
				"fault\":\"\",\"type\":[\"string\",\"null\"]},{\"name\":\"GT_RECORD_MODIFICATION_TIME\",\"defau" +
				"lt\":\"\",\"type\":\"string\"}]}");
		private long _EVENT_ID;
		private int _YEAR;
		private string _DATA_OWNER;
		private string _BANK;
		private string _AGREEMENT_ID;
		private string _ENTRY_DATE;
		private string _VALUE_DATE;
		private string _AMOUNT;
		private string _BALANCE;
		private string _CURRENCY_CODE;
		private string _LCY_AMOUNT;
		private string _TRANSACTION_BANK;
		private string _TRANSACTION_CODE;
		private string _BATCH_NUMBER;
		private string _REFERENCE_NUMBER;
		private string _CATEGORY_CODE;
		private string _CATEGORY;
		private string _OWNER_ID;
		private string _EXTERNAL_REFERENCE;
		private string _EVENT_SOURCE_CODE;
		private string _PAYMENT_TYPE;
		private System.Nullable<int> _TRANSACTION_SEQUENCE_NUMBER;
		private string _EVENT_GROUP_ID;
		private string _DUE_DATE;
		private string _COUNTERPARTY_ID;
		private string _IS_HANDLING_FEE;
		private string _VOID_CODE;
		private string _VOID_CODE_DATE;
		private string _BOOKING_DATE;
		private System.Nullable<int> _ATM_CODE;
		private System.Nullable<int> _MERCHANT_AGREEMENT_NUMBER;
		private System.Nullable<int> _CHEQUE_GUARANTEE_NUMBER;
		private string _CREATED_BY;
		private string _CREATED_DATE;
		private string _REFERENCE;
		private string _REFERENCE_DESCRIPTION;
		private string _EXTENDED_REFERENCE;
		private string _LOAD_DATE;
		private string _AGREEMENT_PID;
		private string _COUNTERPARTY_AGREEMENT_ID;
		private string _COUNTERPARTY_AGREEMENT_PID;
		private string _COUNTERPARTY_REFERENCE;
		private string _OPERATION_REFERENCE;
		private string _EXTERNAL_OPERATION_REFERENCE;
		private string _TRANSACTION_REFERENCE;
		private string _ORDERER_ID;
		private string _ORDERER_NAME;
		private string _BENEFICIARY_ID;
		private string _BENEFICIARY_NAME;
		private string _BATCH_REFERENCE;
		private string _MERCHANT_NAME;
		private string _CARD_ID;
		private string _ORDERER_CROSSRATE;
		private string _ORDERER_EXCHANGERATE;
		private string _BENEFICIARY_CROSSRATE;
		private string _BENEFICIARY_EXCHANGERATE;
		private string _CARD_NUMBER_MASKED;
		private string _EXTERNAL_USER;
		private string _PAYMENT_PURPOSE_CODE;
		private string _OPERATION_TYPE;
		private string _TELLER_ID;
		private string _ENTITY;
		private string _STANDARD_DESCRIPTION;
		private string _CHANNEL_CODE;
		private string _GT_RECORD_MODIFICATION_TIME;
		public virtual Schema Schema
		{
			get
			{
				return FINANCIAL_EVENTS._SCHEMA;
			}
		}
		public long EVENT_ID
		{
			get
			{
				return this._EVENT_ID;
			}
			set
			{
				this._EVENT_ID = value;
			}
		}
		public int YEAR
		{
			get
			{
				return this._YEAR;
			}
			set
			{
				this._YEAR = value;
			}
		}
		public string DATA_OWNER
		{
			get
			{
				return this._DATA_OWNER;
			}
			set
			{
				this._DATA_OWNER = value;
			}
		}
		public string BANK
		{
			get
			{
				return this._BANK;
			}
			set
			{
				this._BANK = value;
			}
		}
		public string AGREEMENT_ID
		{
			get
			{
				return this._AGREEMENT_ID;
			}
			set
			{
				this._AGREEMENT_ID = value;
			}
		}
		public string ENTRY_DATE
		{
			get
			{
				return this._ENTRY_DATE;
			}
			set
			{
				this._ENTRY_DATE = value;
			}
		}
		public string VALUE_DATE
		{
			get
			{
				return this._VALUE_DATE;
			}
			set
			{
				this._VALUE_DATE = value;
			}
		}
		public string AMOUNT
		{
			get
			{
				return this._AMOUNT;
			}
			set
			{
				this._AMOUNT = value;
			}
		}
		public string BALANCE
		{
			get
			{
				return this._BALANCE;
			}
			set
			{
				this._BALANCE = value;
			}
		}
		public string CURRENCY_CODE
		{
			get
			{
				return this._CURRENCY_CODE;
			}
			set
			{
				this._CURRENCY_CODE = value;
			}
		}
		public string LCY_AMOUNT
		{
			get
			{
				return this._LCY_AMOUNT;
			}
			set
			{
				this._LCY_AMOUNT = value;
			}
		}
		public string TRANSACTION_BANK
		{
			get
			{
				return this._TRANSACTION_BANK;
			}
			set
			{
				this._TRANSACTION_BANK = value;
			}
		}
		public string TRANSACTION_CODE
		{
			get
			{
				return this._TRANSACTION_CODE;
			}
			set
			{
				this._TRANSACTION_CODE = value;
			}
		}
		public string BATCH_NUMBER
		{
			get
			{
				return this._BATCH_NUMBER;
			}
			set
			{
				this._BATCH_NUMBER = value;
			}
		}
		public string REFERENCE_NUMBER
		{
			get
			{
				return this._REFERENCE_NUMBER;
			}
			set
			{
				this._REFERENCE_NUMBER = value;
			}
		}
		public string CATEGORY_CODE
		{
			get
			{
				return this._CATEGORY_CODE;
			}
			set
			{
				this._CATEGORY_CODE = value;
			}
		}
		public string CATEGORY
		{
			get
			{
				return this._CATEGORY;
			}
			set
			{
				this._CATEGORY = value;
			}
		}
		public string OWNER_ID
		{
			get
			{
				return this._OWNER_ID;
			}
			set
			{
				this._OWNER_ID = value;
			}
		}
		public string EXTERNAL_REFERENCE
		{
			get
			{
				return this._EXTERNAL_REFERENCE;
			}
			set
			{
				this._EXTERNAL_REFERENCE = value;
			}
		}
		public string EVENT_SOURCE_CODE
		{
			get
			{
				return this._EVENT_SOURCE_CODE;
			}
			set
			{
				this._EVENT_SOURCE_CODE = value;
			}
		}
		public string PAYMENT_TYPE
		{
			get
			{
				return this._PAYMENT_TYPE;
			}
			set
			{
				this._PAYMENT_TYPE = value;
			}
		}
		public System.Nullable<int> TRANSACTION_SEQUENCE_NUMBER
		{
			get
			{
				return this._TRANSACTION_SEQUENCE_NUMBER;
			}
			set
			{
				this._TRANSACTION_SEQUENCE_NUMBER = value;
			}
		}
		public string EVENT_GROUP_ID
		{
			get
			{
				return this._EVENT_GROUP_ID;
			}
			set
			{
				this._EVENT_GROUP_ID = value;
			}
		}
		public string DUE_DATE
		{
			get
			{
				return this._DUE_DATE;
			}
			set
			{
				this._DUE_DATE = value;
			}
		}
		public string COUNTERPARTY_ID
		{
			get
			{
				return this._COUNTERPARTY_ID;
			}
			set
			{
				this._COUNTERPARTY_ID = value;
			}
		}
		public string IS_HANDLING_FEE
		{
			get
			{
				return this._IS_HANDLING_FEE;
			}
			set
			{
				this._IS_HANDLING_FEE = value;
			}
		}
		public string VOID_CODE
		{
			get
			{
				return this._VOID_CODE;
			}
			set
			{
				this._VOID_CODE = value;
			}
		}
		public string VOID_CODE_DATE
		{
			get
			{
				return this._VOID_CODE_DATE;
			}
			set
			{
				this._VOID_CODE_DATE = value;
			}
		}
		public string BOOKING_DATE
		{
			get
			{
				return this._BOOKING_DATE;
			}
			set
			{
				this._BOOKING_DATE = value;
			}
		}
		public System.Nullable<int> ATM_CODE
		{
			get
			{
				return this._ATM_CODE;
			}
			set
			{
				this._ATM_CODE = value;
			}
		}
		public System.Nullable<int> MERCHANT_AGREEMENT_NUMBER
		{
			get
			{
				return this._MERCHANT_AGREEMENT_NUMBER;
			}
			set
			{
				this._MERCHANT_AGREEMENT_NUMBER = value;
			}
		}
		public System.Nullable<int> CHEQUE_GUARANTEE_NUMBER
		{
			get
			{
				return this._CHEQUE_GUARANTEE_NUMBER;
			}
			set
			{
				this._CHEQUE_GUARANTEE_NUMBER = value;
			}
		}
		public string CREATED_BY
		{
			get
			{
				return this._CREATED_BY;
			}
			set
			{
				this._CREATED_BY = value;
			}
		}
		public string CREATED_DATE
		{
			get
			{
				return this._CREATED_DATE;
			}
			set
			{
				this._CREATED_DATE = value;
			}
		}
		public string REFERENCE
		{
			get
			{
				return this._REFERENCE;
			}
			set
			{
				this._REFERENCE = value;
			}
		}
		public string REFERENCE_DESCRIPTION
		{
			get
			{
				return this._REFERENCE_DESCRIPTION;
			}
			set
			{
				this._REFERENCE_DESCRIPTION = value;
			}
		}
		public string EXTENDED_REFERENCE
		{
			get
			{
				return this._EXTENDED_REFERENCE;
			}
			set
			{
				this._EXTENDED_REFERENCE = value;
			}
		}
		public string LOAD_DATE
		{
			get
			{
				return this._LOAD_DATE;
			}
			set
			{
				this._LOAD_DATE = value;
			}
		}
		public string AGREEMENT_PID
		{
			get
			{
				return this._AGREEMENT_PID;
			}
			set
			{
				this._AGREEMENT_PID = value;
			}
		}
		public string COUNTERPARTY_AGREEMENT_ID
		{
			get
			{
				return this._COUNTERPARTY_AGREEMENT_ID;
			}
			set
			{
				this._COUNTERPARTY_AGREEMENT_ID = value;
			}
		}
		public string COUNTERPARTY_AGREEMENT_PID
		{
			get
			{
				return this._COUNTERPARTY_AGREEMENT_PID;
			}
			set
			{
				this._COUNTERPARTY_AGREEMENT_PID = value;
			}
		}
		public string COUNTERPARTY_REFERENCE
		{
			get
			{
				return this._COUNTERPARTY_REFERENCE;
			}
			set
			{
				this._COUNTERPARTY_REFERENCE = value;
			}
		}
		public string OPERATION_REFERENCE
		{
			get
			{
				return this._OPERATION_REFERENCE;
			}
			set
			{
				this._OPERATION_REFERENCE = value;
			}
		}
		public string EXTERNAL_OPERATION_REFERENCE
		{
			get
			{
				return this._EXTERNAL_OPERATION_REFERENCE;
			}
			set
			{
				this._EXTERNAL_OPERATION_REFERENCE = value;
			}
		}
		public string TRANSACTION_REFERENCE
		{
			get
			{
				return this._TRANSACTION_REFERENCE;
			}
			set
			{
				this._TRANSACTION_REFERENCE = value;
			}
		}
		public string ORDERER_ID
		{
			get
			{
				return this._ORDERER_ID;
			}
			set
			{
				this._ORDERER_ID = value;
			}
		}
		public string ORDERER_NAME
		{
			get
			{
				return this._ORDERER_NAME;
			}
			set
			{
				this._ORDERER_NAME = value;
			}
		}
		public string BENEFICIARY_ID
		{
			get
			{
				return this._BENEFICIARY_ID;
			}
			set
			{
				this._BENEFICIARY_ID = value;
			}
		}
		public string BENEFICIARY_NAME
		{
			get
			{
				return this._BENEFICIARY_NAME;
			}
			set
			{
				this._BENEFICIARY_NAME = value;
			}
		}
		public string BATCH_REFERENCE
		{
			get
			{
				return this._BATCH_REFERENCE;
			}
			set
			{
				this._BATCH_REFERENCE = value;
			}
		}
		public string MERCHANT_NAME
		{
			get
			{
				return this._MERCHANT_NAME;
			}
			set
			{
				this._MERCHANT_NAME = value;
			}
		}
		public string CARD_ID
		{
			get
			{
				return this._CARD_ID;
			}
			set
			{
				this._CARD_ID = value;
			}
		}
		public string ORDERER_CROSSRATE
		{
			get
			{
				return this._ORDERER_CROSSRATE;
			}
			set
			{
				this._ORDERER_CROSSRATE = value;
			}
		}
		public string ORDERER_EXCHANGERATE
		{
			get
			{
				return this._ORDERER_EXCHANGERATE;
			}
			set
			{
				this._ORDERER_EXCHANGERATE = value;
			}
		}
		public string BENEFICIARY_CROSSRATE
		{
			get
			{
				return this._BENEFICIARY_CROSSRATE;
			}
			set
			{
				this._BENEFICIARY_CROSSRATE = value;
			}
		}
		public string BENEFICIARY_EXCHANGERATE
		{
			get
			{
				return this._BENEFICIARY_EXCHANGERATE;
			}
			set
			{
				this._BENEFICIARY_EXCHANGERATE = value;
			}
		}
		public string CARD_NUMBER_MASKED
		{
			get
			{
				return this._CARD_NUMBER_MASKED;
			}
			set
			{
				this._CARD_NUMBER_MASKED = value;
			}
		}
		public string EXTERNAL_USER
		{
			get
			{
				return this._EXTERNAL_USER;
			}
			set
			{
				this._EXTERNAL_USER = value;
			}
		}
		public string PAYMENT_PURPOSE_CODE
		{
			get
			{
				return this._PAYMENT_PURPOSE_CODE;
			}
			set
			{
				this._PAYMENT_PURPOSE_CODE = value;
			}
		}
		public string OPERATION_TYPE
		{
			get
			{
				return this._OPERATION_TYPE;
			}
			set
			{
				this._OPERATION_TYPE = value;
			}
		}
		public string TELLER_ID
		{
			get
			{
				return this._TELLER_ID;
			}
			set
			{
				this._TELLER_ID = value;
			}
		}
		public string ENTITY
		{
			get
			{
				return this._ENTITY;
			}
			set
			{
				this._ENTITY = value;
			}
		}
		public string STANDARD_DESCRIPTION
		{
			get
			{
				return this._STANDARD_DESCRIPTION;
			}
			set
			{
				this._STANDARD_DESCRIPTION = value;
			}
		}
		public string CHANNEL_CODE
		{
			get
			{
				return this._CHANNEL_CODE;
			}
			set
			{
				this._CHANNEL_CODE = value;
			}
		}
		public string GT_RECORD_MODIFICATION_TIME
		{
			get
			{
				return this._GT_RECORD_MODIFICATION_TIME;
			}
			set
			{
				this._GT_RECORD_MODIFICATION_TIME = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.EVENT_ID;
			case 1: return this.YEAR;
			case 2: return this.DATA_OWNER;
			case 3: return this.BANK;
			case 4: return this.AGREEMENT_ID;
			case 5: return this.ENTRY_DATE;
			case 6: return this.VALUE_DATE;
			case 7: return this.AMOUNT;
			case 8: return this.BALANCE;
			case 9: return this.CURRENCY_CODE;
			case 10: return this.LCY_AMOUNT;
			case 11: return this.TRANSACTION_BANK;
			case 12: return this.TRANSACTION_CODE;
			case 13: return this.BATCH_NUMBER;
			case 14: return this.REFERENCE_NUMBER;
			case 15: return this.CATEGORY_CODE;
			case 16: return this.CATEGORY;
			case 17: return this.OWNER_ID;
			case 18: return this.EXTERNAL_REFERENCE;
			case 19: return this.EVENT_SOURCE_CODE;
			case 20: return this.PAYMENT_TYPE;
			case 21: return this.TRANSACTION_SEQUENCE_NUMBER;
			case 22: return this.EVENT_GROUP_ID;
			case 23: return this.DUE_DATE;
			case 24: return this.COUNTERPARTY_ID;
			case 25: return this.IS_HANDLING_FEE;
			case 26: return this.VOID_CODE;
			case 27: return this.VOID_CODE_DATE;
			case 28: return this.BOOKING_DATE;
			case 29: return this.ATM_CODE;
			case 30: return this.MERCHANT_AGREEMENT_NUMBER;
			case 31: return this.CHEQUE_GUARANTEE_NUMBER;
			case 32: return this.CREATED_BY;
			case 33: return this.CREATED_DATE;
			case 34: return this.REFERENCE;
			case 35: return this.REFERENCE_DESCRIPTION;
			case 36: return this.EXTENDED_REFERENCE;
			case 37: return this.LOAD_DATE;
			case 38: return this.AGREEMENT_PID;
			case 39: return this.COUNTERPARTY_AGREEMENT_ID;
			case 40: return this.COUNTERPARTY_AGREEMENT_PID;
			case 41: return this.COUNTERPARTY_REFERENCE;
			case 42: return this.OPERATION_REFERENCE;
			case 43: return this.EXTERNAL_OPERATION_REFERENCE;
			case 44: return this.TRANSACTION_REFERENCE;
			case 45: return this.ORDERER_ID;
			case 46: return this.ORDERER_NAME;
			case 47: return this.BENEFICIARY_ID;
			case 48: return this.BENEFICIARY_NAME;
			case 49: return this.BATCH_REFERENCE;
			case 50: return this.MERCHANT_NAME;
			case 51: return this.CARD_ID;
			case 52: return this.ORDERER_CROSSRATE;
			case 53: return this.ORDERER_EXCHANGERATE;
			case 54: return this.BENEFICIARY_CROSSRATE;
			case 55: return this.BENEFICIARY_EXCHANGERATE;
			case 56: return this.CARD_NUMBER_MASKED;
			case 57: return this.EXTERNAL_USER;
			case 58: return this.PAYMENT_PURPOSE_CODE;
			case 59: return this.OPERATION_TYPE;
			case 60: return this.TELLER_ID;
			case 61: return this.ENTITY;
			case 62: return this.STANDARD_DESCRIPTION;
			case 63: return this.CHANNEL_CODE;
			case 64: return this.GT_RECORD_MODIFICATION_TIME;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.EVENT_ID = (System.Int64)fieldValue; break;
			case 1: this.YEAR = (System.Int32)fieldValue; break;
			case 2: this.DATA_OWNER = (System.String)fieldValue; break;
			case 3: this.BANK = (System.String)fieldValue; break;
			case 4: this.AGREEMENT_ID = (System.String)fieldValue; break;
			case 5: this.ENTRY_DATE = (System.String)fieldValue; break;
			case 6: this.VALUE_DATE = (System.String)fieldValue; break;
			case 7: this.AMOUNT = (System.String)fieldValue; break;
			case 8: this.BALANCE = (System.String)fieldValue; break;
			case 9: this.CURRENCY_CODE = (System.String)fieldValue; break;
			case 10: this.LCY_AMOUNT = (System.String)fieldValue; break;
			case 11: this.TRANSACTION_BANK = (System.String)fieldValue; break;
			case 12: this.TRANSACTION_CODE = (System.String)fieldValue; break;
			case 13: this.BATCH_NUMBER = (System.String)fieldValue; break;
			case 14: this.REFERENCE_NUMBER = (System.String)fieldValue; break;
			case 15: this.CATEGORY_CODE = (System.String)fieldValue; break;
			case 16: this.CATEGORY = (System.String)fieldValue; break;
			case 17: this.OWNER_ID = (System.String)fieldValue; break;
			case 18: this.EXTERNAL_REFERENCE = (System.String)fieldValue; break;
			case 19: this.EVENT_SOURCE_CODE = (System.String)fieldValue; break;
			case 20: this.PAYMENT_TYPE = (System.String)fieldValue; break;
			case 21: this.TRANSACTION_SEQUENCE_NUMBER = (System.Nullable<int>)fieldValue; break;
			case 22: this.EVENT_GROUP_ID = (System.String)fieldValue; break;
			case 23: this.DUE_DATE = (System.String)fieldValue; break;
			case 24: this.COUNTERPARTY_ID = (System.String)fieldValue; break;
			case 25: this.IS_HANDLING_FEE = (System.String)fieldValue; break;
			case 26: this.VOID_CODE = (System.String)fieldValue; break;
			case 27: this.VOID_CODE_DATE = (System.String)fieldValue; break;
			case 28: this.BOOKING_DATE = (System.String)fieldValue; break;
			case 29: this.ATM_CODE = (System.Nullable<int>)fieldValue; break;
			case 30: this.MERCHANT_AGREEMENT_NUMBER = (System.Nullable<int>)fieldValue; break;
			case 31: this.CHEQUE_GUARANTEE_NUMBER = (System.Nullable<int>)fieldValue; break;
			case 32: this.CREATED_BY = (System.String)fieldValue; break;
			case 33: this.CREATED_DATE = (System.String)fieldValue; break;
			case 34: this.REFERENCE = (System.String)fieldValue; break;
			case 35: this.REFERENCE_DESCRIPTION = (System.String)fieldValue; break;
			case 36: this.EXTENDED_REFERENCE = (System.String)fieldValue; break;
			case 37: this.LOAD_DATE = (System.String)fieldValue; break;
			case 38: this.AGREEMENT_PID = (System.String)fieldValue; break;
			case 39: this.COUNTERPARTY_AGREEMENT_ID = (System.String)fieldValue; break;
			case 40: this.COUNTERPARTY_AGREEMENT_PID = (System.String)fieldValue; break;
			case 41: this.COUNTERPARTY_REFERENCE = (System.String)fieldValue; break;
			case 42: this.OPERATION_REFERENCE = (System.String)fieldValue; break;
			case 43: this.EXTERNAL_OPERATION_REFERENCE = (System.String)fieldValue; break;
			case 44: this.TRANSACTION_REFERENCE = (System.String)fieldValue; break;
			case 45: this.ORDERER_ID = (System.String)fieldValue; break;
			case 46: this.ORDERER_NAME = (System.String)fieldValue; break;
			case 47: this.BENEFICIARY_ID = (System.String)fieldValue; break;
			case 48: this.BENEFICIARY_NAME = (System.String)fieldValue; break;
			case 49: this.BATCH_REFERENCE = (System.String)fieldValue; break;
			case 50: this.MERCHANT_NAME = (System.String)fieldValue; break;
			case 51: this.CARD_ID = (System.String)fieldValue; break;
			case 52: this.ORDERER_CROSSRATE = (System.String)fieldValue; break;
			case 53: this.ORDERER_EXCHANGERATE = (System.String)fieldValue; break;
			case 54: this.BENEFICIARY_CROSSRATE = (System.String)fieldValue; break;
			case 55: this.BENEFICIARY_EXCHANGERATE = (System.String)fieldValue; break;
			case 56: this.CARD_NUMBER_MASKED = (System.String)fieldValue; break;
			case 57: this.EXTERNAL_USER = (System.String)fieldValue; break;
			case 58: this.PAYMENT_PURPOSE_CODE = (System.String)fieldValue; break;
			case 59: this.OPERATION_TYPE = (System.String)fieldValue; break;
			case 60: this.TELLER_ID = (System.String)fieldValue; break;
			case 61: this.ENTITY = (System.String)fieldValue; break;
			case 62: this.STANDARD_DESCRIPTION = (System.String)fieldValue; break;
			case 63: this.CHANNEL_CODE = (System.String)fieldValue; break;
			case 64: this.GT_RECORD_MODIFICATION_TIME = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
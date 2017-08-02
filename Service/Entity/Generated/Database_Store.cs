
//     这个文件由模版自动生成
//     对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// 
//     下面的连接设置用于生成该文件
// 
//     连接字符串名称: `LMConnectionStringMain`
//     数据库躯动:     `System.Data.SqlClient`
//     连接字符串:     `Data Source=ZXJK-PC;Initial Catalog=pipe;Persist Security Info=True;User ID=sa;password=**zapped**;MultipleActiveResultSets=True`
//     Schema:         ``
//     包含视图:       `True`
//     生成时间:       `2017-08-02 11:45:27`

using System;
using Service.Common.Entity;

namespace WorldStore.DataBase
{
    #region ProductUnit
    [TableAttribute("ProductUnit")]
    public partial class ProductUnit : EntityBase<ProductUnit>
    {
        private int _productUnit_ID;
        private string _name;
        private int _employee_ID;
        private DateTime? _createDate;
        private string _remark;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("ProductUnit_ID", IsAuto = true)]
        public int ProductUnit_ID { get => _productUnit_ID; set => _productUnit_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? CreateDate { get => _createDate; set => _createDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }
    }
    #endregion

    #region EnterStock
    [TableAttribute("EnterStock")]
    public partial class EnterStock : EntityBase<EnterStock>
    {
        private int _enterStock_ID;
        private DateTime _enterDate;
        private int _dept_ID;
        private int _storeHouse_ID;
        private int _employee_ID;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("EnterStock_ID", IsAuto = true)]
        public int EnterStock_ID { get => _enterStock_ID; set => _enterStock_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime EnterDate { get => _enterDate; set => _enterDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int StoreHouse_ID { get => _storeHouse_ID; set => _storeHouse_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }
    }
    #endregion

    #region GetProDetail
    [TableAttribute("GetProDetail")]
    public partial class GetProDetail : EntityBase<GetProDetail>
    {
        private string _name;
        private string _productListName;
        private string _specName;
        private string _unitName;
        private int? _quantity;
        private string _supplierName;
        private string _spell;
        private string _shortname;
        private decimal _price;
        private decimal _offering_Price;
        private int _product_ID;
        private string _address;
        private int _productList_ID;
        private string _s_spell;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ProductListName { get => _productListName; set => _productListName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SpecName { get => _specName; set => _specName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string UnitName { get => _unitName; set => _unitName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SupplierName { get => _supplierName; set => _supplierName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string spell { get => _spell; set => _spell = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string shortname { get => _shortname; set => _shortname = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Offering_Price { get => _offering_Price; set => _offering_Price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int ProductList_ID { get => _productList_ID; set => _productList_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string s_spell { get => _s_spell; set => _s_spell = value; }
    }
    #endregion

    #region BackStock
    [TableAttribute("BackStock")]
    public partial class BackStock : EntityBase<BackStock>
    {
        private int _backStock_ID;
        private DateTime _backDate;
        private int _dept_ID;
        private int _storeHouse_ID;
        private int _employee_ID;
        private string _remark;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("BackStock_ID", IsAuto = true)]
        public int BackStock_ID { get => _backStock_ID; set => _backStock_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime BackDate { get => _backDate; set => _backDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int StoreHouse_ID { get => _storeHouse_ID; set => _storeHouse_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }
    }
    #endregion

    #region onhand
    [TableAttribute("onhand")]
    public partial class onhand : EntityBase<onhand>
    {
        private int _storeid;
        private int _goodsid;
        private int __onhand;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int storeid { get => _storeid; set => _storeid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int goodsid { get => _goodsid; set => _goodsid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int _onhand { get => __onhand; set => __onhand = value; }
    }
    #endregion

    #region LeaveStock
    [TableAttribute("LeaveStock")]
    public partial class LeaveStock : EntityBase<LeaveStock>
    {
        private int _leaveStock_ID;
        private DateTime _leaveDate;
        private int _dept_ID;
        private int _storeHouse_ID;
        private int _toStoreHouse_ID;
        private int _employee_ID;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("LeaveStock_ID", IsAuto = true)]
        public int LeaveStock_ID { get => _leaveStock_ID; set => _leaveStock_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime LeaveDate { get => _leaveDate; set => _leaveDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int StoreHouse_ID { get => _storeHouse_ID; set => _storeHouse_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int ToStoreHouse_ID { get => _toStoreHouse_ID; set => _toStoreHouse_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }
    }
    #endregion

    #region SaleOrder
    [TableAttribute("SaleOrder")]
    public partial class SaleOrder : EntityBase<SaleOrder>
    {
        private int _saleOrder_ID;
        private DateTime _writeDate;
        private DateTime _insureDate;
        private DateTime _endDate;
        private int _dept_ID;
        private int _customer_ID;
        private int _employee_ID;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("SaleOrder_ID", IsAuto = true)]
        public int SaleOrder_ID { get => _saleOrder_ID; set => _saleOrder_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime WriteDate { get => _writeDate; set => _writeDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime InsureDate { get => _insureDate; set => _insureDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime EndDate { get => _endDate; set => _endDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Customer_ID { get => _customer_ID; set => _customer_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }
    }
    #endregion

    #region SaleOrder_Detail
    [TableAttribute("SaleOrder_Detail")]
    public partial class SaleOrder_Detail : EntityBase<SaleOrder_Detail>
    {
        private int _saleOrder_ID;
        private int _product_ID;
        private int _quantity;
        private decimal? _price;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int SaleOrder_ID { get => _saleOrder_ID; set => _saleOrder_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? Price { get => _price; set => _price = value; }
    }
    #endregion

    #region Buy
    [TableAttribute("Buy")]
    public partial class Buy : EntityBase<Buy>
    {
        private int _buy_ID;
        private DateTime _comeDate;
        private int _dept_ID;
        private int _employee_ID;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Buy_ID", IsAuto = true)]
        public int Buy_ID { get => _buy_ID; set => _buy_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime ComeDate { get => _comeDate; set => _comeDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }
    }
    #endregion

    #region EUser
    [TableAttribute("EUser")]
    public partial class EUser : EntityBase<EUser>
    {
        private int _userId;
        private string _userName;
        private string _passWord;
        private string _email;
        private string _name;
        private string _sex;
        private int? _age;
        private string _iD_Card;
        private string _phone;
        private string _mobilPhone;
        private string _address;
        private string _postalcode;
        private string _work;
        private decimal? _income;
        private int? _integral;
        private DateTime _createTime;
        private DateTime _laseLogin;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("UserId", IsAuto = true)]
        public int UserId { get => _userId; set => _userId = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string UserName { get => _userName; set => _userName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string PassWord { get => _passWord; set => _passWord = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Email { get => _email; set => _email = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Sex { get => _sex; set => _sex = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? Age { get => _age; set => _age = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ID_Card { get => _iD_Card; set => _iD_Card = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Phone { get => _phone; set => _phone = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string MobilPhone { get => _mobilPhone; set => _mobilPhone = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Postalcode { get => _postalcode; set => _postalcode = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Work { get => _work; set => _work = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? Income { get => _income; set => _income = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? Integral { get => _integral; set => _integral = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime CreateTime { get => _createTime; set => _createTime = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime LaseLogin { get => _laseLogin; set => _laseLogin = value; }
    }
    #endregion

    #region Customer
    [TableAttribute("Customer")]
    public partial class Customer : EntityBase<Customer>
    {
        private int _customer_ID;
        private string _name;
        private string _address;
        private string _phone;
        private string _fax;
        private string _postalCode;
        private string _constactPerson;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Customer_ID", IsAuto = true)]
        public int Customer_ID { get => _customer_ID; set => _customer_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Phone { get => _phone; set => _phone = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Fax { get => _fax; set => _fax = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ConstactPerson { get => _constactPerson; set => _constactPerson = value; }
    }
    #endregion

    #region Dept
    [TableAttribute("Dept")]
    public partial class Dept : EntityBase<Dept>
    {
        private int _dept_ID;
        private string _name;
        private string _remark;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Dept_ID", IsAuto = true)]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }
    }
    #endregion

    #region Dept_Supplier
    [TableAttribute("Dept_Supplier")]
    public partial class Dept_Supplier : EntityBase<Dept_Supplier>
    {
        private int _dept_ID;
        private int _supplier_ID;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Supplier_ID { get => _supplier_ID; set => _supplier_ID = value; }
    }
    #endregion

    #region BuyOrder
    [TableAttribute("BuyOrder")]
    public partial class BuyOrder : EntityBase<BuyOrder>
    {
        private int _buyOrder_ID;
        private DateTime _writeDate;
        private DateTime _insureDate;
        private DateTime _endDate;
        private int _dept_ID;
        private int _supplier_ID;
        private int _employee_ID;
        private bool _produced;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("BuyOrder_ID", IsAuto = true)]
        public int BuyOrder_ID { get => _buyOrder_ID; set => _buyOrder_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime WriteDate { get => _writeDate; set => _writeDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime InsureDate { get => _insureDate; set => _insureDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime EndDate { get => _endDate; set => _endDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Supplier_ID { get => _supplier_ID; set => _supplier_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public bool Produced { get => _produced; set => _produced = value; }
    }
    #endregion

    #region Buy_Detail
    [TableAttribute("Buy_Detail")]
    public partial class Buy_Detail : EntityBase<Buy_Detail>
    {
        private int _buy_ID;
        private int _product_ID;
        private int _buyOrder_ID;
        private int _quantity;
        private decimal _price;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Buy_ID { get => _buy_ID; set => _buy_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int BuyOrder_ID { get => _buyOrder_ID; set => _buyOrder_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }
    }
    #endregion

    #region goods
    [TableAttribute("goods")]
    public partial class good : EntityBase<good>
    {
        private int _goodsid;
        private string _code;
        private string _name;
        private string _shortname;
        private string _specs;
        private string _unit;
        private int _inf_costingtypeid;
        private int _gcmid;
        private int _kind;
        private int _goodstypeid;
        private int _typeflag;
        private decimal? _topqty;
        private decimal? _downqty;
        private decimal _onhand;
        private decimal _aprice;
        private decimal _lowprice;
        private decimal _highprice;
        private int? _validdates;
        private string _cancmb;
        private int? _clientid;
        private int _leadtime;
        private decimal _minpurcaseqty;
        private decimal _maxpurcaseqty;
        private decimal _orderaddqty;
        private string _pyassist;
        private int? _comminfoid;
        private int? _affixinfoid;
        private int _shopid;
        private string _batchctrl;
        private string _closed;
        private string _status;
        private int _upflag;
        private string _unitname1;
        private decimal _unitrate1;
        private string _unitname2;
        private decimal? _unitrate2;
        private string _unitname3;
        private decimal? _unitrate3;
        private string _unitname4;
        private decimal? _unitrate4;
        private string _unitname5;
        private decimal? _unitrate5;
        private string _goodsuserdef1;
        private string _goodsuserdef2;
        private string _goodsuserdef3;
        private string _goodsuserdef4;
        private string _goodsuserdef5;
        private string _goodsuserdef6;
        private string _goodsuserdef7;
        private string _goodsuserdef8;
        private string _goodsuserdef9;
        private string _goodsuserdef10;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int goodsid { get => _goodsid; set => _goodsid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string code { get => _code; set => _code = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string shortname { get => _shortname; set => _shortname = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string specs { get => _specs; set => _specs = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string unit { get => _unit; set => _unit = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int inf_costingtypeid { get => _inf_costingtypeid; set => _inf_costingtypeid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int gcmid { get => _gcmid; set => _gcmid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int kind { get => _kind; set => _kind = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int goodstypeid { get => _goodstypeid; set => _goodstypeid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int typeflag { get => _typeflag; set => _typeflag = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? topqty { get => _topqty; set => _topqty = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? downqty { get => _downqty; set => _downqty = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal onhand { get => _onhand; set => _onhand = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal aprice { get => _aprice; set => _aprice = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal lowprice { get => _lowprice; set => _lowprice = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal highprice { get => _highprice; set => _highprice = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? validdates { get => _validdates; set => _validdates = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string cancmb { get => _cancmb; set => _cancmb = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? clientid { get => _clientid; set => _clientid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int leadtime { get => _leadtime; set => _leadtime = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal minpurcaseqty { get => _minpurcaseqty; set => _minpurcaseqty = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal maxpurcaseqty { get => _maxpurcaseqty; set => _maxpurcaseqty = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal orderaddqty { get => _orderaddqty; set => _orderaddqty = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string pyassist { get => _pyassist; set => _pyassist = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? comminfoid { get => _comminfoid; set => _comminfoid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? affixinfoid { get => _affixinfoid; set => _affixinfoid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int shopid { get => _shopid; set => _shopid = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string batchctrl { get => _batchctrl; set => _batchctrl = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string closed { get => _closed; set => _closed = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string status { get => _status; set => _status = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int upflag { get => _upflag; set => _upflag = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string unitname1 { get => _unitname1; set => _unitname1 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal unitrate1 { get => _unitrate1; set => _unitrate1 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string unitname2 { get => _unitname2; set => _unitname2 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? unitrate2 { get => _unitrate2; set => _unitrate2 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string unitname3 { get => _unitname3; set => _unitname3 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? unitrate3 { get => _unitrate3; set => _unitrate3 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string unitname4 { get => _unitname4; set => _unitname4 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? unitrate4 { get => _unitrate4; set => _unitrate4 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string unitname5 { get => _unitname5; set => _unitname5 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? unitrate5 { get => _unitrate5; set => _unitrate5 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef1 { get => _goodsuserdef1; set => _goodsuserdef1 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef2 { get => _goodsuserdef2; set => _goodsuserdef2 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef3 { get => _goodsuserdef3; set => _goodsuserdef3 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef4 { get => _goodsuserdef4; set => _goodsuserdef4 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef5 { get => _goodsuserdef5; set => _goodsuserdef5 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef6 { get => _goodsuserdef6; set => _goodsuserdef6 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef7 { get => _goodsuserdef7; set => _goodsuserdef7 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef8 { get => _goodsuserdef8; set => _goodsuserdef8 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef9 { get => _goodsuserdef9; set => _goodsuserdef9 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string goodsuserdef10 { get => _goodsuserdef10; set => _goodsuserdef10 = value; }
    }
    #endregion

    #region v_BuyOrderList
    [TableAttribute("v_BuyOrderList")]
    public partial class v_BuyOrderList : EntityBase<v_BuyOrderList>
    {
        private DateTime _writeDate;
        private int _buyOrder_ID;
        private string _name;
        private string _employeeName;
        private bool _produced;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime WriteDate { get => _writeDate; set => _writeDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int BuyOrder_ID { get => _buyOrder_ID; set => _buyOrder_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public bool Produced { get => _produced; set => _produced = value; }
    }
    #endregion

    #region Supplier
    [TableAttribute("Supplier")]
    public partial class Supplier : EntityBase<Supplier>
    {
        private int _supplier_ID;
        private string _name;
        private string _address;
        private string _phone;
        private string _fax;
        private string _postalCode;
        private string _constactPerson;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Supplier_ID", IsAuto = true)]
        public int Supplier_ID { get => _supplier_ID; set => _supplier_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Phone { get => _phone; set => _phone = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Fax { get => _fax; set => _fax = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ConstactPerson { get => _constactPerson; set => _constactPerson = value; }
    }
    #endregion

    #region user
    [TableAttribute("user")]
    public partial class user : EntityBase<user>
    {
        private string _user_Id;
        private string _user_Pwd;
        private string _again_Pwd;
        private string _bel_Group;
        private string _div_Type;
        private string _user_Auth;
        private string _auth_Type;
        private string _user_Status;
        private string _create_User;
        private string _create_Date;
        private string _create_Time;
        private string _appr_User;
        private string _appr_Date;
        private string _appr_Time;
        private string _pwd_Date;
        private double _err_Count;
        private string _use_eJCIC;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string User_Id { get => _user_Id; set => _user_Id = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string User_Pwd { get => _user_Pwd; set => _user_Pwd = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Again_Pwd { get => _again_Pwd; set => _again_Pwd = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Bel_Group { get => _bel_Group; set => _bel_Group = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Div_Type { get => _div_Type; set => _div_Type = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string User_Auth { get => _user_Auth; set => _user_Auth = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Auth_Type { get => _auth_Type; set => _auth_Type = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string User_Status { get => _user_Status; set => _user_Status = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Create_User { get => _create_User; set => _create_User = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Create_Date { get => _create_Date; set => _create_Date = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Create_Time { get => _create_Time; set => _create_Time = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Appr_User { get => _appr_User; set => _appr_User = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Appr_Date { get => _appr_Date; set => _appr_Date = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Appr_Time { get => _appr_Time; set => _appr_Time = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Pwd_Date { get => _pwd_Date; set => _pwd_Date = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public double Err_Count { get => _err_Count; set => _err_Count = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Use_eJCIC { get => _use_eJCIC; set => _use_eJCIC = value; }
    }
    #endregion

    #region Show_Sale_Detail
    [TableAttribute("Show_Sale_Detail")]
    public partial class Show_Sale_Detail : EntityBase<Show_Sale_Detail>
    {
        private decimal _price;
        private int _quantity;
        private int _product_ID;
        private string _name;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }
    }
    #endregion

    #region Employee
    [TableAttribute("Employee")]
    public partial class Employee : EntityBase<Employee>
    {
        private int _employee_ID;
        private string _userName;
        private string _passWord;
        private int _dept_ID;
        private string _name;
        private string _duty;
        private string _gender;
        private DateTime _birthDate;
        private DateTime? _hireDate;
        private DateTime? _matureDate;
        private string _identityCard;
        private string _address;
        private string _phone;
        private string _email;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Employee_ID", IsAuto = true)]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string UserName { get => _userName; set => _userName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string PassWord { get => _passWord; set => _passWord = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Duty { get => _duty; set => _duty = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Gender { get => _gender; set => _gender = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? HireDate { get => _hireDate; set => _hireDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? MatureDate { get => _matureDate; set => _matureDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string IdentityCard { get => _identityCard; set => _identityCard = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Phone { get => _phone; set => _phone = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Email { get => _email; set => _email = value; }
    }
    #endregion

    #region UserRight
    [TableAttribute("UserRight")]
    public partial class UserRight : EntityBase<UserRight>
    {
        private int _userId;
        private int _rights;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int UserId { get => _userId; set => _userId = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Rights { get => _rights; set => _rights = value; }
    }
    #endregion

    #region saledetail
    [TableAttribute("saledetail")]
    public partial class saledetail : EntityBase<saledetail>
    {
        private int _sale_ID;
        private decimal _price;
        private string _name;
        private string _unitName;
        private int _quantity;
        private string _specName;
        private int _product_ID;
        private DateTime _saleDate;
        private string _tradeNo;
        private string _gatheringWay;
        private string _account;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Sale_ID { get => _sale_ID; set => _sale_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string UnitName { get => _unitName; set => _unitName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SpecName { get => _specName; set => _specName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime SaleDate { get => _saleDate; set => _saleDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string TradeNo { get => _tradeNo; set => _tradeNo = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string GatheringWay { get => _gatheringWay; set => _gatheringWay = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Account { get => _account; set => _account = value; }
    }
    #endregion

    #region Product_Supplier
    [TableAttribute("Product_Supplier")]
    public partial class Product_Supplier : EntityBase<Product_Supplier>
    {
        private int _product_ID;
        private int _supplier_ID;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Product_ID", IsAuto = false)]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Supplier_ID { get => _supplier_ID; set => _supplier_ID = value; }
    }
    #endregion

    #region ProductSpec
    [TableAttribute("ProductSpec")]
    public partial class ProductSpec : EntityBase<ProductSpec>
    {
        private int _productSpec_ID;
        private string _name;
        private int? _employee_ID;
        private DateTime? _createDate;
        private string _remark;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("ProductSpec_ID", IsAuto = true)]
        public int ProductSpec_ID { get => _productSpec_ID; set => _productSpec_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? CreateDate { get => _createDate; set => _createDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }
    }
    #endregion

    #region Product
    [TableAttribute("Product")]
    public partial class Product : EntityBase<Product>
    {
        private int _product_ID;
        private int? _code;
        private int _productList_ID;
        private string _name;
        private string _shortname;
        private string _spell;
        private string _s_spell;
        private int _productSpec_ID;
        private int _productUnit_ID;
        private decimal _price;
        private decimal _offering_Price;
        private int _employee_ID;
        private DateTime _createDate;
        private string _remark;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Product_ID", IsAuto = true)]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? Code { get => _code; set => _code = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int ProductList_ID { get => _productList_ID; set => _productList_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string shortname { get => _shortname; set => _shortname = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string spell { get => _spell; set => _spell = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string s_spell { get => _s_spell; set => _s_spell = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int ProductSpec_ID { get => _productSpec_ID; set => _productSpec_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int ProductUnit_ID { get => _productUnit_ID; set => _productUnit_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Offering_Price { get => _offering_Price; set => _offering_Price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }
    }
    #endregion

    #region Specs
    [TableAttribute("Specs")]
    public partial class Spec : EntityBase<Spec>
    {
        private int _productSpec_ID;
        private string _name;
        private int? _employee_ID;
        private DateTime? _createDate;
        private string _remark;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("ProductSpec_ID", IsAuto = false)]
        public int ProductSpec_ID { get => _productSpec_ID; set => _productSpec_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? CreateDate { get => _createDate; set => _createDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }
    }
    #endregion

    #region SaleGather
    [TableAttribute("SaleGather")]
    public partial class SaleGather : EntityBase<SaleGather>
    {
        private int _sale_ID;
        private DateTime _saleDate;
        private string _tradeNo;
        private string _address;
        private string _gatheringWay;
        private string _name;
        private string _storeAdd;
        private string _custName;
        private string _account;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Sale_ID { get => _sale_ID; set => _sale_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime SaleDate { get => _saleDate; set => _saleDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string TradeNo { get => _tradeNo; set => _tradeNo = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string GatheringWay { get => _gatheringWay; set => _gatheringWay = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string StoreAdd { get => _storeAdd; set => _storeAdd = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string CustName { get => _custName; set => _custName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Account { get => _account; set => _account = value; }
    }
    #endregion

    #region SaleDefinite
    [TableAttribute("SaleDefinite")]
    public partial class SaleDefinite : EntityBase<SaleDefinite>
    {
        private string _tradeNo;
        private int _product_ID;
        private string _productName;
        private string _specName;
        private string _unitName;
        private int _quantity;
        private decimal _price;
        private string _storeAdd;
        private string _account;
        private string _gatheringWay;
        private DateTime _saleDate;
        private int _sale_ID;
        private string _address;
        private string _shortname;
        private string _name;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string TradeNo { get => _tradeNo; set => _tradeNo = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ProductName { get => _productName; set => _productName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SpecName { get => _specName; set => _specName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string UnitName { get => _unitName; set => _unitName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string StoreAdd { get => _storeAdd; set => _storeAdd = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Account { get => _account; set => _account = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string GatheringWay { get => _gatheringWay; set => _gatheringWay = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime SaleDate { get => _saleDate; set => _saleDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Sale_ID { get => _sale_ID; set => _sale_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string shortname { get => _shortname; set => _shortname = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }
    }
    #endregion

    #region CheckStock
    [TableAttribute("CheckStock")]
    public partial class CheckStock : EntityBase<CheckStock>
    {
        private int _product_ID;
        private string _productName;
        private string _shortname;
        private string _listName;
        private string _supplierName;
        private string _specName;
        private string _unitName;
        private string _address;
        private int _quantity;
        private DateTime? _lastLeaveDate;
        private int _storeHouse_ID;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ProductName { get => _productName; set => _productName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string shortname { get => _shortname; set => _shortname = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ListName { get => _listName; set => _listName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SupplierName { get => _supplierName; set => _supplierName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SpecName { get => _specName; set => _specName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string UnitName { get => _unitName; set => _unitName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? LastLeaveDate { get => _lastLeaveDate; set => _lastLeaveDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int StoreHouse_ID { get => _storeHouse_ID; set => _storeHouse_ID = value; }
    }
    #endregion

    #region EnterStockDefinite
    [TableAttribute("EnterStockDefinite")]
    public partial class EnterStockDefinite : EntityBase<EnterStockDefinite>
    {
        private int _enterStock_ID;
        private int _product_ID;
        private string _productName;
        private string _unitName;
        private string _specName;
        private string _shortname;
        private string _name;
        private DateTime _enterDate;
        private string _storeAdd;
        private decimal? _price;
        private int _quantity;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int EnterStock_ID { get => _enterStock_ID; set => _enterStock_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ProductName { get => _productName; set => _productName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string UnitName { get => _unitName; set => _unitName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SpecName { get => _specName; set => _specName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string shortname { get => _shortname; set => _shortname = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime EnterDate { get => _enterDate; set => _enterDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string StoreAdd { get => _storeAdd; set => _storeAdd = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
    #endregion

    #region ProductNote
    [TableAttribute("ProductNote")]
    public partial class ProductNote : EntityBase<ProductNote>
    {
        private string _name;
        private int _product_ID;
        private DateTime _enterDate;
        private DateTime _saleDate;
        private DateTime _backDate;
        private int _quantity;
        private int _expr1;
        private int _expr2;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime EnterDate { get => _enterDate; set => _enterDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime SaleDate { get => _saleDate; set => _saleDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime BackDate { get => _backDate; set => _backDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Expr1 { get => _expr1; set => _expr1 = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Expr2 { get => _expr2; set => _expr2 = value; }
    }
    #endregion

    #region BackSale_Detail
    [TableAttribute("BackSale_Detail")]
    public partial class BackSale_Detail : EntityBase<BackSale_Detail>
    {
        private int _backSale_ID;
        private int _product_ID;
        private decimal _quantity;
        private decimal _price;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int BackSale_ID { get => _backSale_ID; set => _backSale_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }
    }
    #endregion

    #region BackStock_Detail
    [TableAttribute("BackStock_Detail")]
    public partial class BackStock_Detail : EntityBase<BackStock_Detail>
    {
        private int _backStock_ID;
        private int _product_ID;
        private decimal _quantity;
        private decimal _price;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int BackStock_ID { get => _backStock_ID; set => _backStock_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }
    }
    #endregion

    #region EnterStock_Detail
    [TableAttribute("EnterStock_Detail")]
    public partial class EnterStock_Detail : EntityBase<EnterStock_Detail>
    {
        private int _enterStock_ID;
        private int _product_ID;
        private decimal _quantity;
        private decimal? _price;
        private bool _haveInvoice;
        private string _invoiceNum;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int EnterStock_ID { get => _enterStock_ID; set => _enterStock_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal? Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public bool HaveInvoice { get => _haveInvoice; set => _haveInvoice = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string InvoiceNum { get => _invoiceNum; set => _invoiceNum = value; }
    }
    #endregion

    #region LeaveStock_Detail
    [TableAttribute("LeaveStock_Detail")]
    public partial class LeaveStock_Detail : EntityBase<LeaveStock_Detail>
    {
        private int _leaveStock_ID;
        private int _product_ID;
        private decimal _quantity;
        private decimal _price;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int LeaveStock_ID { get => _leaveStock_ID; set => _leaveStock_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }
    }
    #endregion

    #region Sale_Detail
    [TableAttribute("Sale_Detail")]
    public partial class Sale_Detail : EntityBase<Sale_Detail>
    {
        private int _sale_ID;
        private int _product_ID;
        private int? _saleOrder_ID;
        private decimal _quantity;
        private decimal _price;
        private int? _discount;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Sale_ID { get => _sale_ID; set => _sale_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? SaleOrder_ID { get => _saleOrder_ID; set => _saleOrder_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int? Discount { get => _discount; set => _discount = value; }
    }
    #endregion

    #region StockPile
    [TableAttribute("StockPile")]
    public partial class StockPile : EntityBase<StockPile>
    {
        private int _stockPile_ID;
        private int _dept_ID;
        private int _storeHouse_ID;
        private int _product_ID;
        private DateTime _firstEnterDate;
        private DateTime? _lastLeaveDate;
        private decimal _quantity;
        private decimal _price;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("StockPile_ID", IsAuto = true)]
        public int StockPile_ID { get => _stockPile_ID; set => _stockPile_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int StoreHouse_ID { get => _storeHouse_ID; set => _storeHouse_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime FirstEnterDate { get => _firstEnterDate; set => _firstEnterDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? LastLeaveDate { get => _lastLeaveDate; set => _lastLeaveDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }
    }
    #endregion

    #region Temp
    [TableAttribute("Temp")]
    public partial class Temp : EntityBase<Temp>
    {
        private int _iD;
        private string _name;


        /// <summary>
        /// 
        /// </summary>
        [Property(IsStorage = false)]
        public int ID { get => _iD; set => _iD = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }
    }
    #endregion

    #region BuyOrder_Detail
    [TableAttribute("BuyOrder_Detail")]
    public partial class BuyOrder_Detail : EntityBase<BuyOrder_Detail>
    {
        private int _buyOrder_ID;
        private int _product_ID;
        private decimal _quantity;
        private decimal _price;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int BuyOrder_ID { get => _buyOrder_ID; set => _buyOrder_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Quantity { get => _quantity; set => _quantity = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }
    }
    #endregion

    #region Sale
    [TableAttribute("Sale")]
    public partial class Sale : EntityBase<Sale>
    {
        private int _sale_ID;
        private DateTime _saleDate;
        private string _tradeNo;
        private int _dept_ID;
        private int _employee_ID;
        private int _storeHouse_ID;
        private string _address;
        private string _account;
        private string _gatheringWay;
        private int _customer;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Sale_ID", IsAuto = true)]
        public int Sale_ID { get => _sale_ID; set => _sale_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime SaleDate { get => _saleDate; set => _saleDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string TradeNo { get => _tradeNo; set => _tradeNo = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int StoreHouse_ID { get => _storeHouse_ID; set => _storeHouse_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Account { get => _account; set => _account = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string GatheringWay { get => _gatheringWay; set => _gatheringWay = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Customer { get => _customer; set => _customer = value; }
    }
    #endregion

    #region BackSale
    [TableAttribute("BackSale")]
    public partial class BackSale : EntityBase<BackSale>
    {
        private int _backSale_ID;
        private DateTime _backDate;
        private int _dept_ID;
        private int _storeHouse_ID;
        private int _employee_ID;
        private string _remark;
        private string _address;
        private string _account;
        private string _gatheringWay;
        private int _customer;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("BackSale_ID", IsAuto = true)]
        public int BackSale_ID { get => _backSale_ID; set => _backSale_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime BackDate { get => _backDate; set => _backDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int StoreHouse_ID { get => _storeHouse_ID; set => _storeHouse_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Account { get => _account; set => _account = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string GatheringWay { get => _gatheringWay; set => _gatheringWay = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Customer { get => _customer; set => _customer = value; }
    }
    #endregion

    #region HasChecked
    [TableAttribute("HasChecked")]
    public partial class HasChecked : EntityBase<HasChecked>
    {
        private int _iD;
        private DateTime _month;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("ID", IsAuto = true)]
        public int ID { get => _iD; set => _iD = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime Month { get => _month; set => _month = value; }
    }
    #endregion

    #region v_ProInfoList
    [TableAttribute("v_ProInfoList")]
    public partial class v_ProInfoList : EntityBase<v_ProInfoList>
    {
        private string _name;
        private string _productListName;
        private string _specName;
        private string _unitName;
        private string _supplierName;
        private string _spell;
        private string _shortname;
        private decimal _price;
        private decimal _offering_Price;
        private int _productList_ID;
        private string _s_spell;
        private int _product_ID;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string ProductListName { get => _productListName; set => _productListName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SpecName { get => _specName; set => _specName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string UnitName { get => _unitName; set => _unitName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string SupplierName { get => _supplierName; set => _supplierName = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string spell { get => _spell; set => _spell = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string shortname { get => _shortname; set => _shortname = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Price { get => _price; set => _price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public decimal Offering_Price { get => _offering_Price; set => _offering_Price = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int ProductList_ID { get => _productList_ID; set => _productList_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string s_spell { get => _s_spell; set => _s_spell = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Product_ID { get => _product_ID; set => _product_ID = value; }
    }
    #endregion

    #region Dept_Customer
    [TableAttribute("Dept_Customer")]
    public partial class Dept_Customer : EntityBase<Dept_Customer>
    {
        private int _dept_ID;
        private int _customer_ID;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Dept_ID { get => _dept_ID; set => _dept_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Customer_ID { get => _customer_ID; set => _customer_ID = value; }
    }
    #endregion

    #region StoreHouse
    [TableAttribute("StoreHouse")]
    public partial class StoreHouse : EntityBase<StoreHouse>
    {
        private int _storeHouse_ID;
        private string _address;
        private string _phone;
        private int _employee_ID;
        private DateTime? _createDate;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("StoreHouse_ID", IsAuto = true)]
        public int StoreHouse_ID { get => _storeHouse_ID; set => _storeHouse_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Phone { get => _phone; set => _phone = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? CreateDate { get => _createDate; set => _createDate = value; }
    }
    #endregion

    #region ProductClass
    [TableAttribute("ProductClass")]
    public partial class ProductClass : EntityBase<ProductClass>
    {
        private int _productClass_ID;
        private string _name;
        private int _employee_ID;
        private DateTime? _createDate;
        private string _remark;


        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("ProductClass_ID", IsAuto = true)]
        public int ProductClass_ID { get => _productClass_ID; set => _productClass_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? CreateDate { get => _createDate; set => _createDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }
    }
    #endregion

    #region ProductList
    [TableAttribute("ProductList")]
    public partial class ProductList : EntityBase<ProductList>
    {
        private int _productClass_ID;
        private int _productList_ID;
        private string _name;
        private int _employee_ID;
        private DateTime? _createDate;
        private string _remark;


        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int ProductClass_ID { get => _productClass_ID; set => _productClass_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("ProductList_ID", IsAuto = true)]
        public int ProductList_ID { get => _productList_ID; set => _productList_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID { get => _employee_ID; set => _employee_ID = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime? CreateDate { get => _createDate; set => _createDate = value; }

        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark { get => _remark; set => _remark = value; }
    }
    #endregion

}

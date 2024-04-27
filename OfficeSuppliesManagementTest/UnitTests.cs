using Moq;
using MySql.Data.MySqlClient;
using OfficeSuppliesManagement;
using System.Data;

namespace OfficeSuppliesManagementTest
{
    [TestFixture]
    public class UpdateProductTests
    {
        private Mock<IDbConnection> _mockConnection;
        private Mock<IDbCommand> _mockCommand;
        private UpdateProductForm _form;

        [SetUp]
        public void SetUp()
        {
            // Create a new instance of the form
            _form = new UpdateProductForm();

            // Mock the MySqlConnection and MySqlCommand
            _mockConnection = new Mock<IDbConnection>();
            _mockCommand = new Mock<IDbCommand>();

            // Set up the command to return our mocked command object
            _mockConnection.Setup(m => m.CreateCommand()).Returns(_mockCommand.Object);
        }

        [Test]
        public void UpdateButton_Click_UpdatesProduct()
        {
            // Arrange
            _form.ProductName = "Test Product";
            _form.ProductDescription = "This is a test product.";
            _form.ProductPrice = "10.99";
            _form.ProductCategoryId = "1";
            _form.btnUpdateProduct.PerformClick();

            // Assert
            _mockCommand.Verify(cmd => cmd.ExecuteNonQuery(), Times.Once);
        }

        [TearDown]
        public void dispose()
        {
            _form.Dispose();
        }
    }


    [TestFixture]
    public class AddProductTests : AddProductForm
    {
        private Mock<IDbConnection> _mockConnection;
        private Mock<IDbCommand> _mockCommand;
        private AddProductForm _form;

        [SetUp]
        public void SetUp()
        {
            // Create a new instance of the form
            _form = new AddProductForm();

            // Mock the MySqlConnection and MySqlCommand
            _mockConnection = new Mock<IDbConnection>();
            _mockCommand = new Mock<IDbCommand>();

            // Set up the command to return our mocked command object
            _mockConnection.Setup(m => m.CreateCommand()).Returns(_mockCommand.Object);
        }

        [Test]
        public void AddNewProductButton_Click_AddsNewProduct()
        {
            // Arrange
            _form.ProductName = "Test Product";
            _form.ProductDescription = "This is a test product.";
            _form.ProductPrice = "10.99";
            _form.ProductQuantity = "100";
            _form.ProductCategoryId = "1";
            _form.btnAddNewProduct.PerformClick();

            // Assert
            _mockCommand.Verify(cmd => cmd.ExecuteNonQuery(), Times.Once);
        }

        [TearDown]
        public void dispose()
        {
            _form.Dispose();
        }
    }
}
using Moq;
using MySql.Data.MySqlClient;
using OfficeSuppliesManagement;
using System.Data;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;

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
            _form.txtName.Text = "Test Product";
            _form.txtDescription.Text = "This is a test product.";
            _form.txtPrice.Text = "10.99";
            _form.txtQuantity.Text = "1";
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
            _form.txtName.Text = "Test Product";
            _form.txtDescription.Text = "This is a test product.";
            _form.txtPrice.Text = "10.99";
            _form.txtQuantity.Text = "100";
            _form.txtCategoryId.Text = "1";
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

    // Integration Tests
    // These tests are designed to verify the complete functionality of form interactions with the actual database.
    // They complement the existing unit tests by ensuring that the forms not only trigger the expected database commands but also result in the correct changes within the database itself.

    [TestFixture]
    public class ProductFormTests
    {
        private AddProductForm addProductForm;

        [SetUp]
        public void Setup()
        {
            
            addProductForm = new AddProductForm();
            addProductForm.Show(); 
        }

        [Test]
        public void AddProductForm_AddsProductSuccessfully()
        {
            addProductForm.ProductName = "New Product";
            addProductForm.ProductDescription = "A valid description";
            addProductForm.ProductPrice = "25.99";
            addProductForm.ProductQuantity = "100";
            addProductForm.ProductCategoryId = "1";
            addProductForm.btnAddNewProduct.PerformClick();

            var result = TestDbHelper.GetLastAddedProduct();
            Assert.That(result, Is.Not.Null, "Product should be added successfully to the database.");
        }

        [TearDown]
        public void TearDown()
        {
            addProductForm.Close();
        }
    }

    [TestFixture]
    public class UpdateProductIntegrationTests
    {
        private UpdateProductForm updateProductForm;
        private DAO dao;

        [SetUp]
        public void Setup()
        {
            dao = new DAO();  
            updateProductForm = new UpdateProductForm();  
            updateProductForm.Show();

            
            updateProductForm.SetProductDetails(1, "Updated Product", "Updated description", 29.99M, 50, 2);
        }

        [Test]
        public void UpdateProductForm_UpdatesProductSuccessfully()
        {
            updateProductForm.btnUpdateProduct.PerformClick();

            var updatedProduct = TestDbHelper.GetProductById(1);
            Assert.That(updatedProduct, Is.Not.Null, "Product should be updated successfully in the database.");
            Assert.That(updatedProduct.Name, Is.EqualTo("Updated Product"), "Product name should be updated.");
        }

        [TearDown]
        public void TearDown()
        {
            updateProductForm.Close();
        }
    }
}
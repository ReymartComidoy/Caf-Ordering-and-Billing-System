using System.Text;

namespace Café_Ordering_and_Billing_System
{
    public partial class Form1 : Form
    {
        private const decimal PriceBurger = 85.00m;
        private const decimal PriceChickenSandwich = 75.00m;
        private const decimal PriceSpaghetti = 95.00m;
        private const decimal PriceFrenchFries = 50.00m;

       
        private const decimal PriceSoftDrink = 35.00m;
        private const decimal PriceIcedTea = 40.00m;
        private const decimal PriceCoffee = 45.00m;
        private const decimal PriceBottledWater = 25.00m;

        private decimal subtotal = 0.00m;
        private decimal discountAmount = 0.00m;
        private decimal finalTotal = 0.00m;

        public Form1()
        {
            InitializeComponent();
            SetupDefaults();
        }
        private void SetupDefaults()
        {
            if (cmbDiscount.Items.Count == 0)
            {
                cmbDiscount.Items.AddRange(new string[] { "0%", "5%", "10%", "20%" });
            }
            cmbDiscount.SelectedIndex = 0;
            lblSubtotal.Text = "₱0.00";
            lblTotal.Text = "₱0.00";
            lblChange.Text = "₱0.00";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            subtotal = 0.00m;

            // Food Items
            if (chkBurger.Checked) subtotal += PriceBurger * numBurger.Value;
            if (chkChickenSandwich.Checked) subtotal += PriceChickenSandwich * numChickenSandwich.Value;
            if (chkSpaghetti.Checked) subtotal += PriceSpaghetti * numSpaghetti.Value;
            if (chkFrenchFries.Checked) subtotal += PriceFrenchFries * numFrenchFries.Value;

            // Drink Items
            if (chkSoftDrink.Checked) subtotal += PriceSoftDrink * numSoftDrink.Value;
            if (chkIcedTea.Checked) subtotal += PriceIcedTea * numIcedTea.Value;
            if (chkCoffee.Checked) subtotal += PriceCoffee * numCoffee.Value;
            if (chkBottledWater.Checked) subtotal += PriceBottledWater * numBottledWater.Value;

            if (subtotal == 0.00m)
            {
                MessageBox.Show("Please select at least one item from the menu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate Discount
            decimal discountPercent = 0.00m;
            switch (cmbDiscount.SelectedItem?.ToString())
            {
                case "5%": discountPercent = 0.05m; break;
                case "10%": discountPercent = 0.10m; break;
                case "20%": discountPercent = 0.20m; break;
                default: discountPercent = 0.00m; break;
            }

            discountAmount = subtotal * discountPercent;
            finalTotal = subtotal - discountAmount;

            // Update UI Labels
            lblSubtotal.Text = $"₱{subtotal:F2}";
            lblTotal.Text = $"₱{finalTotal:F2}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (finalTotal == 0.00m)
            {
                MessageBox.Show("Please calculate the order total first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtCashPaid.Text, out decimal cashPaid) || cashPaid < finalTotal)
            {
                MessageBox.Show("Insufficient or invalid payment amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal change = cashPaid - finalTotal;
            lblChange.Text = $"₱{change:F2}";

            GenerateReceipt(cashPaid, change);
        }

        private void GenerateReceipt(decimal cashPaid, decimal change)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==========================================");
            sb.AppendLine("              CAFÉ RECEIPT                ");
            sb.AppendLine("==========================================");
            sb.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine("------------------------------------------");
            sb.AppendLine(string.Format("{0,-20} {1,5} {2,12}", "Item", "Qty", "Price"));
            sb.AppendLine("------------------------------------------");

           
            if (chkBurger.Checked)
                sb.AppendLine(string.Format("{0,-20} {1,5} ₱{2,11:F2}", "Burger", numBurger.Value, PriceBurger * numBurger.Value));
            if (chkChickenSandwich.Checked)
                sb.AppendLine(string.Format("{0,-20} {1,5} ₱{2,11:F2}", "Chicken Sandwich", numChickenSandwich.Value, PriceChickenSandwich * numChickenSandwich.Value));
            if (chkSpaghetti.Checked)
                sb.AppendLine(string.Format("{0,-20} {1,5} ₱{2,11:F2}", "Spaghetti", numSpaghetti.Value, PriceSpaghetti * numSpaghetti.Value));
            if (chkFrenchFries.Checked)
                sb.AppendLine(string.Format("{0,-20} {1,5} ₱{2,11:F2}", "French Fries", numFrenchFries.Value, PriceFrenchFries * numFrenchFries.Value));

            
            if (chkSoftDrink.Checked)
                sb.AppendLine(string.Format("{0,-20} {1,5} ₱{2,11:F2}", "Soft Drink", numSoftDrink.Value, PriceSoftDrink * numSoftDrink.Value));
            if (chkIcedTea.Checked)
                sb.AppendLine(string.Format("{0,-20} {1,5} ₱{2,11:F2}", "Iced Tea", numIcedTea.Value, PriceIcedTea * numIcedTea.Value));
            if (chkCoffee.Checked)
                sb.AppendLine(string.Format("{0,-20} {1,5} ₱{2,11:F2}", "Coffee", numCoffee.Value, PriceCoffee * numCoffee.Value));
            if (chkBottledWater.Checked)
                sb.AppendLine(string.Format("{0,-20} {1,5} ₱{2,11:F2}", "Bottled Water", numBottledWater.Value, PriceBottledWater * numBottledWater.Value));

            sb.AppendLine("------------------------------------------");
            sb.AppendLine(string.Format("{0,-26} ₱{1,11:F2}", "Subtotal:", subtotal));
            sb.AppendLine(string.Format("{0,-26} ₱{1,11:F2}", "Discount:", discountAmount));
            sb.AppendLine(string.Format("{0,-26} ₱{1,11:F2}", "Total Amount:", finalTotal));
            sb.AppendLine(string.Format("{0,-26} ₱{1,11:F2}", "Cash Paid:", cashPaid));
            sb.AppendLine(string.Format("{0,-26} ₱{1,11:F2}", "Change:", change));
            sb.AppendLine("==========================================");
            sb.AppendLine("        Thank you for your order!         ");
            sb.AppendLine("==========================================");

            txtReceipt.Text = sb.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkBurger.Checked = false;
            chkChickenSandwich.Checked = false;
            chkSpaghetti.Checked = false;
            chkFrenchFries.Checked = false;

            chkSoftDrink.Checked = false;
            chkIcedTea.Checked = false;
            chkCoffee.Checked = false;
            chkBottledWater.Checked = false;

            numBurger.Value = 1;
            numChickenSandwich.Value = 1;
            numSpaghetti.Value = 1;
            numFrenchFries.Value = 1;

            numSoftDrink.Value = 1;
            numIcedTea.Value = 1;
            numCoffee.Value = 1;
            numBottledWater.Value = 1;

            txtCashPaid.Clear();
            txtReceipt.Clear();

            subtotal = 0.00m;
            discountAmount = 0.00m;
            finalTotal = 0.00m;

            SetupDefaults();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

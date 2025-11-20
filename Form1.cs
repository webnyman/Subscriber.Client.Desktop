using Subscriber.Client.Desktop.Models;
using Subscriber.Client.Desktop.Services;

namespace Subscriber.Client.Desktop
{
    public partial class Form1 : Form
    {
        private readonly SubscriberApiClient _api;

        public Form1()
        {
            InitializeComponent();

            // Sätt din API-bas-URL här
            _api = new SubscriberApiClient("https://localhost:7247"); // justera porten

            // Koppla eventhandlers
            btnLoad.Click += async (s, e) => await LoadSubscribersAsync();
            btnNew.Click += (s, e) => ClearForm();
            btnSave.Click += async (s, e) => await SaveAsync();
            btnDelete.Click += async (s, e) => await DeleteAsync();
            btnExportXml.Click += async (s, e) => await ExportXmlAsync();

            dgvSubscribers.SelectionChanged += DgvSubscribers_SelectionChanged;
        }

        private async Task LoadSubscribersAsync()
        {
            try
            {
                var list = await _api.GetAllAsync();
                dgvSubscribers.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte hämta prenumeranter: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            txtSubscriptionNumber.Text = "";
            txtPersonalNumber.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            txtDeliveryAddress.Text = "";
            txtPostalCode.Text = "";
            txtCity.Text = "";
        }

        private void DgvSubscribers_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvSubscribers.CurrentRow?.DataBoundItem is SubscriberDto s)
            {
                txtSubscriptionNumber.Text = s.SubscriptionNumber;
                txtPersonalNumber.Text = s.PersonalNumber;
                txtFirstName.Text = s.FirstName;
                txtLastName.Text = s.LastName;
                txtPhoneNumber.Text = s.PhoneNumber;
                txtDeliveryAddress.Text = s.DeliveryAddress;
                txtPostalCode.Text = s.PostalCode;
                txtCity.Text = s.City;
            }
        }

        private SubscriberDto ReadForm()
        {
            return new SubscriberDto
            {
                SubscriptionNumber = txtSubscriptionNumber.Text.Trim(),
                PersonalNumber = txtPersonalNumber.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                DeliveryAddress = txtDeliveryAddress.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                City = txtCity.Text.Trim()
            };
        }

        private async Task SaveAsync()
        {
            var dto = ReadForm();

            if (string.IsNullOrWhiteSpace(dto.SubscriptionNumber))
            {
                MessageBox.Show("Prenumerationsnummer krävs.");
                return;
            }

            try
            {
                // Finns redan?
                var existing = await _api.GetAsync(dto.SubscriptionNumber);

                bool ok;
                if (existing == null)
                {
                    ok = await _api.CreateAsync(dto);
                    if (!ok)
                    {
                        MessageBox.Show("Kunde inte skapa prenumerant (kanske finns redan?).");
                        return;
                    }
                    MessageBox.Show("Prenumerant skapad.");
                }
                else
                {
                    ok = await _api.UpdateAsync(dto.SubscriptionNumber, dto);
                    if (!ok)
                    {
                        MessageBox.Show("Kunde inte uppdatera prenumerant.");
                        return;
                    }
                    MessageBox.Show("Prenumerant uppdaterad.");
                }

                await LoadSubscribersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel vid sparande: {ex.Message}");
            }
        }

        private async Task DeleteAsync()
        {
            var prenr = txtSubscriptionNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(prenr))
            {
                MessageBox.Show("Ange prenumerationsnummer för att ta bort.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Vill du verkligen ta bort prenumerant {prenr}?",
                "Bekräfta borttag",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var ok = await _api.DeleteAsync(prenr);
                if (!ok)
                {
                    MessageBox.Show("Kunde inte ta bort prenumerant (finns den?).");
                    return;
                }

                MessageBox.Show("Prenumerant borttagen.");
                ClearForm();
                await LoadSubscribersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel vid borttag: {ex.Message}");
            }
        }

        private async Task ExportXmlAsync()
        {
            try
            {
                var bytes = await _api.ExportXmlAsync();
                if (bytes == null || bytes.Length == 0)
                {
                    MessageBox.Show("Kunde inte exportera XML.");
                    return;
                }

                using var dialog = new SaveFileDialog
                {
                    Filter = "XML-filer (*.xml)|*.xml|Alla filer (*.*)|*.*",
                    FileName = "subscribers.xml"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    await File.WriteAllBytesAsync(dialog.FileName, bytes);
                    MessageBox.Show("XML exporterat.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel vid XML-export: {ex.Message}");
            }
        }
    }
}

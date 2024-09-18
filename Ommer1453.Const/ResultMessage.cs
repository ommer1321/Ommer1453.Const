namespace Ommer1453.Const
{

    public class ResultMessage
    {
        private string _lang;

        public ResultMessage(string lang)
        {
            _lang = lang;
        }

        public const string OperationSuccessEn = "Operation successful!";
        public const string OperationSuccessTr = "İşlem başarılı!";

        public const string LoginSuccessEn = "Login successful!";
        public const string LoginSuccessTr = "Giriş başarılı!";

        public const string DataRetrievedEn = "Data retrieved successfully!";
        public const string DataRetrievedTr = "Veri başarıyla alındı!";

        public const string DataCreatedEn = "Data created successfully!";
        public const string DataCreatedTr = "Veri başarıyla oluşturuldu!";

        public const string DataUpdatedEn = "Data updated successfully!";
        public const string DataUpdatedTr = "Veri başarıyla güncellendi!";

        public const string DataDeletedEn = "Data deleted successfully!";
        public const string DataDeletedTr = "Veri başarıyla silindi!";

        public const string UserRegisteredEn = "User registered successfully!";
        public const string UserRegisteredTr = "Kullanıcı başarıyla kaydedildi!";

        public const string EmailSentEn = "Email sent successfully!";
        public const string EmailSentTr = "E-posta başarıyla gönderildi!";

        public const string PasswordChangedEn = "Password changed successfully!";
        public const string PasswordChangedTr = "Şifre başarıyla değiştirildi!";

        public const string ProfileUpdatedEn = "Profile updated successfully!";
        public const string ProfileUpdatedTr = "Profil başarıyla güncellendi!";

        public const string SettingsSavedEn = "Settings saved successfully!";
        public const string SettingsSavedTr = "Ayarlar başarıyla kaydedildi!";

        public const string FileUploadedEn = "File uploaded successfully!";
        public const string FileUploadedTr = "Dosya başarıyla yüklendi!";

        public const string ActionCompletedEn = "Action completed successfully!";
        public const string ActionCompletedTr = "Eylem başarıyla tamamlandı!";

        public string OperationSuccess
        {
            get
            {
                return _lang switch
                {
                    "en" => OperationSuccessEn,
                    "tr" => OperationSuccessTr,
                    _ => OperationSuccessTr // Varsayılan olarak Türkçe mesaj
                };
            }
        }

        public string LoginSuccess
        {
            get
            {
                return _lang switch
                {
                    "en" => LoginSuccessEn,
                    "tr" => LoginSuccessTr,
                    _ => LoginSuccessTr
                };
            }
        }

        public string DataRetrieved
        {
            get
            {
                return _lang switch
                {
                    "en" => DataRetrievedEn,
                    "tr" => DataRetrievedTr,
                    _ => DataRetrievedTr
                };
            }
        }

        public string DataCreated
        {
            get
            {
                return _lang switch
                {
                    "en" => DataCreatedEn,
                    "tr" => DataCreatedTr,
                    _ => DataCreatedTr
                };
            }
        }

        public string DataUpdated
        {
            get
            {
                return _lang switch
                {
                    "en" => DataUpdatedEn,
                    "tr" => DataUpdatedTr,
                    _ => DataUpdatedTr
                };
            }
        }

        public string DataDeleted
        {
            get
            {
                return _lang switch
                {
                    "en" => DataDeletedEn,
                    "tr" => DataDeletedTr,
                    _ => DataDeletedTr
                };
            }
        }

        public string UserRegistered
        {
            get
            {
                return _lang switch
                {
                    "en" => UserRegisteredEn,
                    "tr" => UserRegisteredTr,
                    _ => UserRegisteredTr
                };
            }
        }

        public string EmailSent
        {
            get
            {
                return _lang switch
                {
                    "en" => EmailSentEn,
                    "tr" => EmailSentTr,
                    _ => EmailSentTr
                };
            }
        }

        public string PasswordChanged
        {
            get
            {
                return _lang switch
                {
                    "en" => PasswordChangedEn,
                    "tr" => PasswordChangedTr,
                    _ => PasswordChangedTr
                };
            }
        }

        public string ProfileUpdated
        {
            get
            {
                return _lang switch
                {
                    "en" => ProfileUpdatedEn,
                    "tr" => ProfileUpdatedTr,
                    _ => ProfileUpdatedTr
                };
            }
        }

        public string SettingsSaved
        {
            get
            {
                return _lang switch
                {
                    "en" => SettingsSavedEn,
                    "tr" => SettingsSavedTr,
                    _ => SettingsSavedTr
                };
            }
        }

        public string FileUploaded
        {
            get
            {
                return _lang switch
                {
                    "en" => FileUploadedEn,
                    "tr" => FileUploadedTr,
                    _ => FileUploadedTr
                };
            }
        }

        public string ActionCompleted
        {
            get
            {
                return _lang switch
                {
                    "en" => ActionCompletedEn,
                    "tr" => ActionCompletedTr,
                    _ => ActionCompletedTr
                };
            }
        }
    }

}

# 09 Email Validation
Für die Email Validierung wird System.Net.Mail.MailAddress verwendet.
```
public bool IsValidEmailAddress(string email)
{
	try
	{
		var addr = new System.Net.Mail.MailAddress(email);
		return addr.Address == email;
	}
	catch
	{
		return false;
	}
}
```
Dokumentation: https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress?view=net-5.0

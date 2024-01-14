# Camouflage-Shield
A full stack windows form application for sensitive image storing in encrypted format.
(clone the repository and run on visual studio)


Working:
User signup for the application (remember that the otp verification is just for demonstration, else a third party/ an API server have to be used for real world application).
User enter the credentials, gets a username and need to have a strong password.
Restart the application to login.
User will find 3 buttons and a dataset grid.
Button encrypt/save a form will appear to input an image choose a process for encryption and enter a key. your encrypted format for the Base64 form of th eimage will be shown. Save it or not depends.
User can have many such image stored.
(Re-Open the application again to see that the stored format is visible.)
(Algorithmsused here are Advanced Encryption Standard (AES),Data Encryption Standard (DES),Triple DES (3DES), RC2 and Rijndael)
User copy the code either from the display (Encrypted code display TextBox) or from the dataset grid.
Click the view button, paste the code.
The original image will only appear if proper process is selected along with proper key being entered. Else error message.
There is a third button "use hash text encrypter" as name suggest for any text entry corresponding hashed encrypted format will be displayed.
(Algorithmsused here are MD5, SHA-1, SHA-256, SHA-384 and SHA-512)

Note:
MD5, SHA-1, SHA-256, SHA-384 and SHA-512 are used for encrypting and storing the login credentials data, but for understanding purposes the hash text button is used.
(MD5 and SHA1 are low level algorithm for data storing so not used in real world application, but used here for diversity in algorithms)
Also for reference, actual error message are kept visible along with implementational error message.

Limitation:
Do not use on high resolution image(high memory) or very complicated (colorful) image.  This application cannot handel more than 1mb (very high volume of data needs to be processed for this).

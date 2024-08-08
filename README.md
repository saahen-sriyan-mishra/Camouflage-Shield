# Camouflage Shield

Camouflage Shield is a Windows Form application designed for sensitive image storage in an encrypted format.
The project employs various encryption and hashing algorithms to ensure secure user authentication and image protection.

## Features

- User signup with OTP verification (for demonstration purposes).
- Strong password enforcement during user registration.
- Multi-algorithm image encryption (AES, DES, 3DES, RC2, Rijndael).
- Image storage in Base64 format with encryption details.
- Copy and view encrypted image codes.
- Hash text encrypter supporting MD5, SHA-1, SHA-256, SHA-384, and SHA-512.

## Prerequisites

- Visual Studio (for running the project).
- .NET Framework.

## Getting Started

1. Clone the repository.
2. Open the project in Visual Studio.
3. Build and run the application.

## Usage

- Launch the application and sign up for a new account (new user).
- Log in with your credentials.
- Encrypt and save images using different algorithms.
- Copy the encrypted image code.
- View encrypted images using the proper algorithm and key after entering the proper image code.
- Use the hash text encrypter for text-based encryption. (used for demonstartion in case Database not is accessable)

### EXAMPLE

**ACCOUNT:** Format specifications are handled while in signup page
- 21/01/2001
- qardtyh&#64;axcfredfv;asdredf
- 0122334455
- patrick_bateman_9612
- asdASD`1234567

**IMAGE**

![Batman Logo](https://github.com/user-attachments/assets/de229f17-a930-4693-a60b-52bbce84cefd)

**ENCRYPTION**
Process 2
Key: BAT

[Encrypted format for the image](https://github.com/saahen-sriyan-mishra/Camouflage-Shield/blob/main/Batman%20Logo%20Encrypted.txt)  
- (Copy this to test out for yourself)

**Correct process (encryption algorithms from AES, DES, 3DES, RC2, Rijndael) and Key:** It works
![1](https://github.com/user-attachments/assets/6e89f21c-18b1-448f-b52e-03d13f8e63c9)

**Incorrect selection and key**
![2](https://github.com/user-attachments/assets/fb28f266-9fd9-461c-b243-3ba70e2a21b4)
![3](https://github.com/user-attachments/assets/35bbf21d-6fad-472c-8589-d702c43eb32a)


**A hash encryption for having encrypting text:** To demonstrate what happens in backend
![1 1](https://github.com/user-attachments/assets/cd14f80d-498e-4192-9e9f-e4d02ad85af2)
![1 2](https://github.com/user-attachments/assets/4a017cd7-e1c9-46eb-a1eb-a0e88e1dee9c)
![1 3](https://github.com/user-attachments/assets/adb261e3-2983-439f-96ba-ba26212a9459)


-------------------------------------------------------------------------------------------

## Limitations (UPDATED) New version do not contain these issues.
- Avoid high-resolution or very complex images (limited to 1MB).
- The application may face challenges with large volumes of data generated while image processing.

## Limatations
- Dynamic updation limitation (need to re-start application to login, image encrypted code is visible only after re-start)
- Useer profile may not show any text for encryption but can be copy pasted for decrypting and viewing the image.
- Takes a long time to process image to text (base64).

## Security Considerations
- Passwords are hashed using MD5, SHA-1, SHA-256, SHA-384, and SHA-512
- Multi-algorithm image encryption using AES, DES, 3DES, RC2, Rijndael.

## Note:
- MD5, SHA-1, SHA-256, SHA-384 and SHA-512 are used for encrypting and storing the login credentials data, but for understanding purposes the hash text button is used.
- (MD5 and SHA1 are low level algorithm for data storing so not used in real world application, but used here for diversity in algorithms)
- Also for reference, actual error message are kept visible along with implementational error message.
- While using, create a new database for establishing connection and change the reference of database and in Form1.cs line 76 and Encrypt.cs line 363.




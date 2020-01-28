# AES-SecureStrings (Client, Server and Builder)
![Header](https://i.imgur.com/9tDZ3q8.jpg)

This is just a simple project for decrypting strings with a server-side application.
The actual decryption method (AES password) doesn't exsit in the client-side application at all.
It only sends, receives and parses packets (UDP). Packets are masked with a simple XOR.

I've also included a easy-to-use string builder, which AES-protects raw strings.
You can also use the other tool I've included to easily change the encoding key (XOR) the packets are masked with as well.

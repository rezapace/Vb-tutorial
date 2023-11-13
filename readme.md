# Berikut adalah tahapan-tahapan untuk menginstall Link Program:

1. Pertama, install Node.js. Anda bisa mendownload installer Node.js dari [situs resmi Node.js](https://nodejs.org) dan pilih versi yang sesuai dengan sistem operasi yang Anda gunakan. Setelah selesai mengunduh, jalankan installer dan ikuti petunjuk yang diberikan.

2. Setelah Node.js terinstal, install Node-RED dengan menggunakan npm (Node Package Manager). Buka command prompt atau terminal, lalu jalankan perintah berikut untuk menginstall Node-RED secara global:
```
npm install -g --unsafe-perm node-red
```

3. Jika proses instalasi selesai, jalankan Node-RED dengan perintah:
```
node-red
```

4. Setelah Node-RED berjalan, buka browser dan akses alamat [http://localhost:1880](http://localhost:1880) untuk masuk ke antarmuka Node-RED.

5. Selanjutnya, buka Firebase dan login menggunakan akun Google Anda. Setelah masuk ke Firebase Console, buatlah proyek baru atau gunakan proyek yang sudah ada.

6. Setelah membuat proyek, klik tombol "Add Firebase to your web app" untuk mendapatkan konfigurasi Firebase. Salin konfigurasi tersebut dan simpan, karena akan digunakan nanti.

7. Kembali ke antarmuka Node-RED, buatlah flow baru dengan menekan tombol "+". Pada flow baru, drag node "firebase" ke halaman flow.

8. Konfigurasikan node firebase dengan mengklik dua kali pada node tersebut. Isikan informasi yang diperlukan, seperti `Name` (nama konektor), `Firebase URL` (URL Firebase), dan `Secret` (API Key dari Firebase).

9. Setelah konfigurasi selesai, klik tombol "Deploy" untuk menjalankan flow Node-RED.

10. Selamat, Link Program sudah siap digunakan! Anda bisa melakukan integrasi dengan service lainnya atau melakukan modifikasi sesuai kebutuhan Anda.

Demikianlah cara menginstall Link Program menggunakan Node-RED dan Firebase. Semoga berhasil!


## Link Program

 - [Node js](https://nodejs.org/dist/v18.17.1/node-v18.17.1-x64.msi)
 - [Node red](https://nodered.org/docs/getting-started/windows)
 - [Firebase](https://firebase.google.com/?hl=id)

## Screenshots

install screenshoot

![App Screenshot](https://github.com/rezapace/Vb-tutorial/blob/main/realtime%20database%20use%20firebase%20node%20red/screenshoot/photo_2023-09-11_13-22-16.jpg?raw=true)

node red structure
![App Screenshot](https://github.com/rezapace/Vb-tutorial/blob/main/realtime%20database%20use%20firebase%20node%20red/screenshoot/photo_2023-09-11_20-37-01.jpg?raw=true)

firebase structure
![App Screenshot](https://github.com/rezapace/Vb-tutorial/blob/main/realtime%20database%20use%20firebase%20node%20red/screenshoot/photo_2023-09-11_16-32-38.jpg?raw=true)

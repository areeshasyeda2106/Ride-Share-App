# 🚗 RideShare — Desktop Ride Sharing Application

A fully functional desktop ride sharing application built with 
C# and WinForms during my first semester of Software Engineering.

---

## 📋 About the Project

RideShare is a Windows desktop application that simulates a 
complete ride sharing platform. The app supports two user roles 
— passengers and drivers — each with their own dedicated 
dashboard and workflow. Data is persisted using text-based 
file storage.

This was my first major programming project, built from scratch 
to apply object-oriented programming, multi-form navigation, 
and real data handling in a desktop environment.

---

## ✨ Features

- 🔐 **Login & Signup** — User registration and authentication
- 👤 **Passenger Dashboard** — View and manage bookings
- 🚘 **Driver Dashboard** — View profile and manage trips
- 📋 **Passenger Bookings** — Search and book available rides
- 🔍 **Search Ride** — Find rides based on requirements
- 🗺️ **Post Trip** — Drivers can post available trips
- 📁 **Driver Trips** — Drivers can view their posted trips
- 💾 **File-based Storage** — Data saved to .txt files (users, trips, bookings)

---

## 🛠️ Tech Stack

| Technology | Purpose |
|------------|---------|
| C# | Core programming language |
| WinForms (.NET) | Desktop UI framework |
| OOP | App architecture (Backend classes) |
| Text File Storage | Data persistence (.txt files) |

---

## 📁 Project Structure

```
RideShareApp/
├── Backend/
│   ├── backend.cs          # Core logic
│   ├── booking.cs          # Booking model & operations
│   ├── trip.cs             # Trip model & operations
│   └── user.cs             # User model & operations
├── forms/
│   ├── LoginForm.cs        # Login screen
│   ├── SignupForm.cs        # Registration screen
│   ├── PassengerDashboard.cs    # Passenger home
│   ├── PassengerBookingsForm.cs # View/manage bookings
│   ├── SearchRideForm.cs        # Search for rides
│   ├── DriverDashboard.cs       # Driver home
│   ├── DriverTripsForm.cs       # Driver's posted trips
│   └── PostTripForm.cs          # Post a new trip
├── users.txt               # Stored user data
├── trips.txt               # Stored trip data
├── bookings.txt            # Stored booking data
└── Program.cs              # Entry point
```

---

## 🚀 How to Run

1. Clone or download this repository
2. Open `RideShareApp.csproj` in **Visual Studio**
3. Build the solution (**Ctrl + Shift + B**)
4. Run the project (**F5**)

> Requires: Visual Studio 2019 or later, .NET Framework

---

## 🎓 About

Built as a first semester project for my **Bachelor's in 
Software Engineering**. The goal was to design a multi-role 
desktop application with real data handling, clean OOP 
architecture, and a complete user flow from signup to booking.

---

## 📌 Future Improvements

- [ ] Replace .txt storage with SQL database
- [ ] Add real-time ride tracking
- [ ] Implement fare calculation
- [ ] Add rating system for drivers
- [ ] Build an admin panel

---

*Developed by Areesha Syeda — Software Engineering Student*

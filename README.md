# Technical Artist Assignment

## Overview

This project is a mobile-optimized endless driving game inspired by Dashy Crashy. The objective is to survive as long as possible by avoiding obstacles while driving through an infinite procedurally generated road.

The project is developed in Unity using the Universal Render Pipeline (URP) with a focus on performance, clean architecture, stylized visuals, and mobile performance.

---

## Unity Version

**Unity 6.3.9f1 (URP)**

---

## Features

### Core Gameplay

* Endless procedurally generated road
* Lane-based car movement
* Obstacle spawning
* Collision detection
* Distance-based gameplay
* Score system
* Coin collection
* Game Over system
* Restart functionality

### Environment

* Infinite road generation
* Stylized environment assets
* Dynamic Day/Night transition
* Rain effect
* Optimized lighting

### Vehicle

* Stylized car visuals
* Smooth lane movement
* Car tilt animation while switching lanes
* Crash physics on collision
* Camera follow system using Cinemachine

### Visual Effects

* Custom Shader Graph road shader
* Emissive road lane markings
* Car trail particle effect
* Speed line effect
* Crash spark particles
* Lane-switch dust particles
* Rain particle system
* Bright, high-contrast color palette
* Low-poly environment
* Mobile-friendly URP materials

### Audio

* Background music
* Sound effects for gameplay events

### User Interface

* Main gameplay UI
* Score display
* Coin counter
* Game Over screen
* Restart functionality

### Optimization

* Mobile optimized
* GPU Instancing enabled where applicable
* Baked lighting
* Reduced real-time lighting
* Optimized textures
* Optimized materials
* Low-overhead shaders

---

## Controls

### Mobile

* Swipe Left → Move Left
* Swipe Right → Move Right

### Editor

* Left Arrow / A → Move Left
* Right Arrow / D → Move Right

---

## Project Structure

```text
Assets/
│
├── _Materials/
├── Scripts/
├── generic-passenger-car-pack/
└── Harsh/
    ├── Font/
    ├── Materials/
    ├── Models/
    ├── Prefab/
    ├── Scenes/
    ├── Scripts/
    ├── Shader/
    ├── Sounds/
    └── Textures/
```

---

## Custom Shader

A custom Shader Graph shader is used for the road.

Features include:

* Texture tiling support
* Adjustable UV scaling
* Emissive lane markings
* Custom glow intensity
* Mobile-friendly implementation

---

## Optimization Techniques

* Baked Global Illumination
* Single Directional Light
* GPU Instancing
* Texture Atlasing where possible
* Shared Materials
* Optimized Meshes
* Reduced Draw Calls
* Mobile-friendly URP settings

---

## How to Run

### In Unity

1. Open the project in Unity.
2. Open the Main Scene.
3. Press **Play**.

### Android Build

1. Switch Build Platform to **Android**.
2. Build and Run on a connected device.

---

## Assets Used

* Custom stylized road texture
* Custom Shader Graph road shader
* Vehicle model
* Environment assets
* Unity URP
* Cinemachine
* Custom particle effects
* Custom UI assets
* Audio assets

---

## Future Improvements

* Additional vehicle types
* More obstacle variations
* Vehicle customization
* Power-ups
* Online leaderboard
* Achievement system
* Improved weather system

---

## Work Completed

* Designed and assembled the gameplay environment
* Implemented endless procedural road generation
* Implemented player lane movement
* Added obstacle spawning and collision detection
* Implemented score and coin collection systems
* Created a dynamic day/night transition
* Added rain weather effect
* Created a custom Shader Graph road shader with emissive lane markings
* Created custom stylized seamless road textures
* Added car trail particle effects
* Added speed line effects
* Added lane-switch dust particles
* Added crash spark particle effects
* Implemented car tilt animation while changing lanes
* Added blinking turn indicators during lane switching
* Implemented crash physics for the player's vehicle
* Added background music and sound effects
* Designed and implemented the gameplay UI
* Optimized lighting using baked Global Illumination
* Optimized the project for mobile performance using URP and GPU Instancing

---

## Author

**Harsh Bishnoi**

**Technical Artist Assignment**

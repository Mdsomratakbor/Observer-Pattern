# Weather Station Project

The Weather Station Project is a simple implementation of a weather monitoring application using the Observer Pattern. It demonstrates how different display components can receive updates from a central weather data source and display the current weather conditions accordingly.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Architecture](#architecture)
- [Usage](#usage)
- [Installation](#installation)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The Weather Station Project showcases the Observer Pattern in action. It simulates a weather monitoring system where different display components, known as observers, register with a central weather data source, known as the subject. Whenever the weather data changes, the subject notifies all registered observers, and they update their displays with the latest weather conditions.

## Features

- Allows the creation of multiple display components to show different aspects of weather conditions.
- Demonstrates the decoupling of weather data and display components using the Observer Pattern.
- Easy addition and removal of new display components without modifying the subject.

## Architecture

The project consists of the following components:

- **WeatherData (Subject):** Represents the weather monitoring system. Maintains a list of observers and notifies them when weather conditions change.
- **IObserver:** An interface defining the method for observers to receive updates.
- **IDisplayElement:** An interface defining the method for display components to update their displays.
- **CurrentConditionsDisplay:** A concrete observer that displays the current temperature and humidity.
- **StatisticsDisplay:** A concrete observer that displays statistics about temperature.
- **ForecastDisplay:** A concrete observer that displays weather forecasts based on historical data.

## Usage

1. Clone or download the repository.
2. Open the project in your preferred C# development environment.
3. Explore and modify the code to understand the implementation of the Observer Pattern.
4. Run the `WeatherStation` class to see the weather monitoring system in action.

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/weather-station-project.git


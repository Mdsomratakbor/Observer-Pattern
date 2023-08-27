# Observer Pattern

The Observer Pattern Project demonstrates the implementation of the Observer Pattern in a software application. This pattern facilitates communication between objects in a loosely coupled manner, promoting flexibility and modularity.

## Table of Contents

- [Introduction](#introduction)
- [Observer Pattern Overview](#observer-pattern-overview)
- [Project Components](#project-components)
- [Usage](#usage)
-   [Creating Observers and Subjects](#creating-observers-and-subjects)
-   [Updating Observers](#updating-observers)
- [Installation](#installation)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The Observer Pattern is one of the behavioral design patterns. It enables a subject (or "observable") to maintain a list of observers and notify them of state changes. This decoupling between subjects and observers ensures that changes in one component do not tightly affect others, making the code more extensible and maintainable.

## Observer Pattern Overview

In the Observer Pattern:

- **Subject:** Maintains a list of observers and provides methods to add, remove, and notify observers of changes.
- **Observer:** Defines an interface with a method that subjects use to notify observers.
- **ConcreteSubject:** Implements the subject interface. It tracks the state and sends notifications to observers.
- **ConcreteObserver:** Implements the observer interface. Observers register with a subject to receive notifications and update their state.

## Project Components

This project illustrates the Observer Pattern with a weather monitoring scenario:

- **WeatherData (Subject):** Represents the weather monitoring system. Maintains a list of observers and notifies them when weather conditions change.
- **IObserver:** An interface defining the method for observers to receive updates.
- **IDisplayElement:** An interface defining the method for display components to update their displays.
- **CurrentConditionsDisplay:** A concrete observer that displays the current temperature and humidity.
- **StatisticsDisplay:** A concrete observer that displays statistics about temperature.
- **ForecastDisplay:** A concrete observer that displays weather forecasts based on historical data.

## Usage

### Creating Observers and Subjects

1. Create concrete observer classes by implementing the `IObserver` interface.
2. Create the subject class (e.g., `WeatherData`) by implementing the subject interface and adding methods for registering, removing, and notifying observers.

### Updating Observers

1. In the subject class, when a change in state occurs, call the `NotifyObservers` method to trigger updates to all registered observers.
2. Observers, upon receiving a notification, update their state and refresh their displays.

## Installation

1. Clone the repository:

   ```bash
   git clone (https://github.com/Mdsomratakbor/Observer-Pattern.git)https://github.com/Mdsomratakbor/Observer-Pattern.git

## Contributing
Contributions are welcome! If you find any issues or improvements, feel free to submit a pull request.

1. Fork the repository.
2. Create a new branch: git checkout -b feature/your-feature.
3. Commit your changes: git commit -m 'Add a new feature'.
4. Push to the branch: git push origin feature/your-feature.
5. Open a pull request.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

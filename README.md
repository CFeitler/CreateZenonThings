# About Create Zenon Things
This library is strictly for the zenon AddIn Framework and can be used to create zenon objects in Engineering Studio Wizards. A zenon object can be a screen, a frame, a driver, a reaction matrix any many more.

The library is not complete but you are invited to contribute. Just fork this repo over and send me a pull request if you finished a valueable detail.

# Structure

## Parameters
The Parameter classes describe data objects. These data objects are consumed by the according creator classes. Each parameter class has a enum type. This enum is used to identify the type of the class. Also, the parameter class has a set of properties in which the attributes of the zenon object are described. If applicable, each property shall have a default value.

## Basic Creator
The Basic Creator class has a reference to the project in which the zenon things will be created. Also the basic creator takes each parameter object of any type and forwards it to the according specific creator to create the thing in zenon.

## Specific Creator
The creator classes use the parameter object to create the thing in zenon. The creator class must be programmed in such way, that it treats all properties of the parameter class.
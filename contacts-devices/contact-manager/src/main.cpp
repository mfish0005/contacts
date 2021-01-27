#include <Arduino.h>

#include <ESP8266WiFi.h>

#include <DNSServer.h>
#include <ESP8266WebServer.h>
#include <WiFiManager.h>

void setup()
{
  Serial.begin(9600);
  WiFiManager wifiManager;
  wifiManager.autoConnect("NodeMCU-Arduino-PlatformIO");
  Serial.println("Connected!");
}

void loop()
{
  Serial.println("Idle...");
  delay(1000);
}














// #include <Arduino.h>
// #include <ESP8266WiFi.h>

// const char *ssid = "NETGEAR13-5G";
// const char *password = "basicship676";
// bool connected = false;

// uint8_t greenLedPin = D7;

// void setup()
// {
//     pinMode(greenLedPin, OUTPUT);

//     // Serial.begin(115200);
//     Serial.println();
//     Serial.print("Wifi connecting to ");
//     Serial.println(ssid);

//     WiFi.begin(ssid, password);

//     Serial.println();
//     Serial.print("Connecting");

//     while (WiFi.status() != WL_CONNECTED)
//     {
//         delay(500);
//         Serial.print(".");
//     }

//     Serial.println();

//     Serial.println("Wifi Connected Success!");
//     Serial.print("NodeMCU IP Address : ");
//     Serial.println(WiFi.localIP());

//     if (WiFi.status() == WL_CONNECTED)
//     {
//         connected = true;
//     }
// }

// void loop()
// {
//     if (connected == true)
//     {
//         digitalWrite(greenLedPin, LOW);
//         delay(1000);
//         digitalWrite(greenLedPin, HIGH);
//     }
// }

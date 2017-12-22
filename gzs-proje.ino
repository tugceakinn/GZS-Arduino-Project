#include <LiquidCrystal.h>
#define buzzer 2
#define gled 4
#define dled 5
#define gazpin A5
#define deppin A3

int glimit = 350;     // Gaz sensörü için limit değer
int dlimit = 999;     // Titreşim sensörü için limit değer
int gdeger;
int ddeger;
bool gg = false;
bool dd = false;

void setup() {

  Serial.begin(9600);
  pinMode(buzzer, OUTPUT);
  pinMode(gled, OUTPUT);
  pinMode(dled, OUTPUT);
  pinMode(gazpin, INPUT);
  pinMode(deppin, INPUT);
  digitalWrite(buzzer, 0);
  digitalWrite(gled, 1);
  digitalWrite(dled, 1);
  delay(2500);
  digitalWrite(gled, 0);
  digitalWrite(dled, 0);
  lcd.begin(16,2);
  lcd.setCursor(0,0);
  lcd.clear();
  Serial.println("Sistem Çalışıyor");
}

void loop() {

  if (Serial.available()) {
    String gelen;
    gelen = Serial.readString();
    if (gelen.indexOf("alarmvar") > -1) {
      digitalWrite(buzzer, 1);
    }
    if (gelen.indexOf("alarmyok") > -1) {
      digitalWrite(buzzer, 0);
    }
  }

  // Gaz sensörü değer okuma ve gönderme
  gdeger = analogRead(gazpin);
  if (gdeger > glimit) {
    digitalWrite(buzzer, 1);
    digitalWrite(gled, 1);
    if (gg == false) {
		
      Serial.println("Gaz Kaçağı");
	  lcd.print("Gaz Değeri :");
	  lcd.print(gdeger);
      gg = true;
    }
  } else {
    digitalWrite(buzzer, 0);
    digitalWrite(gled, 0);
    gg = false;
  }

  // Titreşim sensörü değer okuma ve gönderme
  ddeger = analogRead(deppin);

  if (ddeger < dlimit) {
    digitalWrite(buzzer, 1);
    digitalWrite(dled, 1);
    if (dd == false) {
      Serial.println("Deprem");
	  lcd.setCursor(0,1);
	  lcd.print("Titreşim Değeri :");
	  lcd.print(ddeger);
      dd = true;
    }
  } else {
    digitalWrite(buzzer, 0);
    digitalWrite(dled, 0);
    dd = false;
  }
  delay(1000);
}

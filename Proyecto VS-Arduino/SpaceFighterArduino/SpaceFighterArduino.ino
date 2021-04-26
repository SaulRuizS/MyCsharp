void setup()
{
  Serial.begin(9600);
  pinMode(2, INPUT_PULLUP);
}

void loop()
{
  int ButtonValue = analogRead(2);
  int X_Value = map(analogRead(A0), 1023, 0, 0, 740);
  int Y_Value = map(analogRead(A1), 1023, 0, 0, 740);
  int ValidButton = 0;
  
  if(ButtonValue <= 1)
  {
    ValidButton = 100;
  }
  
  Serial.print(ButtonValue);
  Serial.print("B");

  Serial.print(X_Value);
  Serial.print("X");

  Serial.print(Y_Value);
  Serial.println("Y");

  delay(100);
}

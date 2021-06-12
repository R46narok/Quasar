SYSTEM_MODE(MANUAL);        
SYSTEM_THREAD(ENABLED); 

#include "Quasar/QBle.h"
#include "Quasar/QDisplay.h"

void setup() 
{
    Serial.begin(9600);

    RGB.control(true);

    Quasar::InitDisplay();
    Quasar::InitBle();
}

void loop() 
{
    Quasar::PresentDisplay();
}
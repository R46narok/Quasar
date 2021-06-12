/******************************************************/
//       THIS IS A GENERATED FILE - DO NOT EDIT       //
/******************************************************/

#include "Particle.h"
#line 1 "d:/Development/Projects/Quasar/quasar_embedded/src/quasar_embedded.ino"
void setup();
void loop();
#line 1 "d:/Development/Projects/Quasar/quasar_embedded/src/quasar_embedded.ino"
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
Reminder
================================================

Preview Release: 2.1.0.1a (22/11/2022) - [Download Here](https://github.com/flappy-boi/Reminder/raw/master/2.1.0.1a.zip)

Stable Release: 2.0.1r (18/11/2022) - [Download Here](https://github.com/flappy-boi/Reminder/raw/master/201r.zip)




Included files
================================================
```
readme.md       This file
Reminder.exe    Main program
data\0.csv      Generic schedule for Sunday
data\1.csv      Generic schedule for Monday
data\2.csv      Generic schedule for Tuesday
data\3.csv      Generic schedule for Wednesday
data\4.csv      Generic schedule for Thursday
data\5.csv      Generic schedule for Friday
data\6.csv      Generic schedule for Saturday
```




Quick Start Guide
================================================

- Open `Reminder.exe`
- It should tell you:
  - Current time,
  - Next event[^1], and
  - Time to next event[^1] (in minutes)
- Double click the bottom line to exit




Personalisation of the Schedules
================================================

- Open the `.csv files` with suitable software.
  - e.g. Excel
- Fields
  - 1st column: Time of event (in min. of day)[^2]
  - 2nd column: Name of event (Max. 10 chars)[^3]
  - Note: The last row must be `1440` (24:00) for it to work properly.
  - You may just edit the generic schedules.
  - Save the file (Ctrl + S) and it will update
    instantly.




Changelog
================================================

2.1.0.1a                              23/11/2022
------------------------------------------------
- Typo fixed.


2.1a            Preview Release       22/11/2022
------------------------------------------------
- Shows version on startup.
- Double click clock to lock opague.
- Manual mode module added. (Non functional)


2.0.1r          Stable Release        18/11/2022
------------------------------------------------
- Generic *.csv files added.
- Supports other devices with different screen-
  size.


2.0b                                  14/11/2022
------------------------------------------------
- Supports editing schedule.
  - Data saved in `*.csv` files. 
- Modified colour coding.
  - Displayed in the clock.


1.4                                   08/11/2022
------------------------------------------------
- Inactivity introduced.
  - Clears the display when its inactive.


1.3                                   05/11/2022
------------------------------------------------
- Hover function added to line 1.
  - Background to blue to increase readability
    over light background.


1.2.1                                 03/11/2022
------------------------------------------------
- Colour coding modified for better readability.
  - Amber -> Gold
  - Green -> Lime


1.2                                   02/11/2022
------------------------------------------------
- Colour-coding implemented.
  - 6 minutes -> Amber
  - 5 minutes -> Green


1.1.1                                 27/10/2022
------------------------------------------------
- Countdown bug fixed.
  - Changed datatype from 'DateTime' to 'int'.


1.1                                   26/10/2022
------------------------------------------------
- Periods added.
- Countdown added.


1.0a                                  24/10/2022
------------------------------------------------
- Original version.



[^1]: Only if current time < last event
[^2]: Hours*60 + Minutes (e.g. `598` for 9:58 and `980` for 16:20.)
[^3]: e.g. `Lunch` and `H01History` would work.

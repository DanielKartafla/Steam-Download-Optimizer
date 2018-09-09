// SteamDownloadOptimizerConsole.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <windows.h>
#include <tchar.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <stdio.h>
#include <stdlib.h>
#include <fstream>
#include <filesystem>
#include <curl/curl.h>

using namespace std;

string getSteamappsPath();
bool dirExists(string path);
bool dirExists(const char *path);


int main()
{
  cout << "Welcome to the Steam Download Optimizer!\n" << endl;
  cout << "Please note that this software or its creators are in no way affiliated \n"
    << "with the digital distribution platform Steam or Valve Corporation.\n"
    << "Furthermore, the developers of this software are not responsible \n"
    << "for any damages that may occur from using this software.\n" 
    << "USE AT YOUR OWN RISK.\n" << endl;

  cout << "By continuing you agree that you have read the disclamer above and are \n"
    << "take full responsibility of running this software." << endl;

  cin.get();

  string steamapps = getSteamappsPath();
  
  cout << "What would you like the Steam Download Optimizer to do?" << endl;

  cin.get();
  return 0;
}

string getSteamappsPath() {
  TCHAR programFilesFolderPath[MAX_PATH] = { 0, };
  ExpandEnvironmentStrings(
    _T("%COMMONPROGRAMFILES%"),
    programFilesFolderPath,
    MAX_PATH);

  wstring programFilesW = programFilesFolderPath;
  string fileSeperator = "\\";
  string steamapps = string(programFilesW.begin(), programFilesW.end()) + fileSeperator + "Steam" + fileSeperator + "steamapps";

  bool confirmed = false;
  if (dirExists(steamapps)) {
    cout << "Is this your steamapps path? (y/n)\n  " << steamapps << endl;
    char confirm;
    cin >> confirm;
    if (toupper(confirm) == 'Y') {
      confirmed = true;
    }
  }
  while(!confirmed){
    cout << "Please enter your steamapps path:" << endl;
    getline(cin, steamapps);

    cout << "Is this your steamapps path? (y/n)\n  " << steamapps << endl;
    char confirm;
    cin >> confirm;
    if (toupper(confirm) == 'Y') {
      confirmed = true;
    }
  }
  cout << "Alright, great!" << endl;

  return steamapps;
}

bool dirExists(string path) {
  char* pathArray = new char[path.length() + 1];
  strcpy_s(pathArray, path.length() + 1, path.c_str());
  return dirExists(pathArray);
}

bool dirExists(const char *path)
{
  struct stat info;

  if (stat(path, &info) != 0)
    return 0;
  else if (info.st_mode & S_IFDIR)
    return 1;
  else
    return 0;
}

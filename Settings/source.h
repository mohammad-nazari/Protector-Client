//Content of file "options.h": 
//gsoap ns service name: Options
//gsoap ns service namespace: Options
//gsoap ns schema namespace: Options

#include <string.h>
#include <vector>

#import "stlvector.h"

typedef std::string xsd__string;
typedef int xsd__int;
typedef bool xsd__bool;
typedef double xsd__double;

class ns__DataBaseInfo
{
	xsd__string	dataBaseInfoServerName;
	xsd__int	dataBaseInfoPort;
	xsd__string	dataBaseInfoUserName;
	xsd__string	dataBaseInfoPassWord;
};

class ns__ClientOptions
{
	ns__DataBaseInfo optionsDataBaseInfo;
	xsd__int optionsTimeRepeat;
};

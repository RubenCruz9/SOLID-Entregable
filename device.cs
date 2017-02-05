
class camera10MP : cameraInterface
{
	float megaPixels = 10.0;

	void takePhoto()
	{
		// Take A Photo Logic
	}
}

class camera5Mp : cameraInterface
{
	float megaPixels = 5.0;

	void takePhoto()
	{
		// Take A Photo Logic
	}
}

class USAPlug : plugInterface
{
	string type = "USA";

	void charge()
	{
		// charge Logic
	}
}

class EPlug : plugInterface
{
	string type = "EU";

	void charge()
	{
		// charge Logic
	}
}

class Samsung : phoneInterface
{
	string os;
	string model;

	void call()
	{
		// call Logic
	}

class Iphone : phoneInterface
{

	string os;
	string model;
	
	void call()
	{
		// call Logic
	}
}
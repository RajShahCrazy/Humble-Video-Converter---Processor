import sys
import glob
import os
import Image
from PIL import Image
import ImageFilter
import ImageOps
import ImageDraw

# Converts the input image to black and white (grayscale)
# The image has to be in the 'Image' module format
def convert_image_to_black_and_white(image):
	black_and_white_image = image.convert("L")
	
	return black_and_white_image.convert("RGB")
	
def main():
	# Get the source and the destination urls
	source = sys.argv[1]
	destination = sys.argv[2]
	
	# Construct the ffmpeg command to extract audio
	ffmpeg_command = "ffmpeg -i " + source + " -vn -ac 2 -ar 44100 -ab 320k -f mp3 " + destination + "\\audio.mp3"
	
	# Extract audio
	os.popen(ffmpeg_command)
	
	# Construct the ffmpeg command to extract frames
	ffmpeg_command = "ffmpeg -i " + source + " " + destination + "\image-%6d.jpeg"
	print ffmpeg_command
	
	# Extract the frames
	os.popen(ffmpeg_command)
	
	# Save current directory
	current_dir = os.getcwd()
	
	# Go the destination directory
	os.chdir(destination)
	
	# Convert each file in the destination
	for file in glob.glob("*.jpeg"):
		print file
		
		# Get the source image
		source_image = Image.open(file)
		
		# Convert the source image to a sketch
		destination_image = convert_image_to_black_and_white(source_image)
		
		print destination_image.size
		
		# Save the converted image
		destination_image.save(file)
	
	# Change back to the directory where ffmpeg is located
	os.chdir(current_dir)
	
	# Generate the ffmpeg command to combine all frames into a video	
	ffmpeg_command = "ffmpeg -i " + destination + "\\image-%6d.jpeg -vcodec libx264 " + destination + "\\" + source.split("\\")[-1].split(".")[0] + ".mp4"
	
	# Combine all frames into a video
	os.popen(ffmpeg_command)
	
	# Generate the ffmpeg command to combine the new video and the original audio
	ffmpeg_command = "ffmpeg -i " + destination + "\\" + source.split("\\")[-1].split(".")[0] + ".mp4" + " -i " + destination + "\\audio.mp3 -vcodec copy -acodec copy " + destination + "\\" + source.split("\\")[-1].split(".")[0] + "_Sketch.mp4"
	print ffmpeg_command
	
	# Combine video and audio
	os.popen(ffmpeg_command)
	
	# Go the destination directory to delete all the unnessary files
	os.chdir(destination)
	
	# Delete all the image files
	for file in glob.glob("*.jpeg"):
		os.remove(file)
	
	# Delete the audio file
	os.remove("audio.mp3")
	
	# Delete the video without audio file
	os.remove(source.split("\\")[-1].split(".")[0] + ".mp4")
	
if __name__ == '__main__':
    main()			

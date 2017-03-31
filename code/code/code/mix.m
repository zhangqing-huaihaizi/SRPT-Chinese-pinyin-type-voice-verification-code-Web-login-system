function y=mix(s1,s2,s3)
fs=10000; %语音信号采样频率为10kHz
r=randsrc(1,1,[1,2,3,4,5,6]);
%s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
%sui ji zao sheng
filepath_r='\soundsrc\';
filepath_r=strcat(filepath_r,int2str(r));
filepath_r=strcat(filepath_r,'.wav');

[x,fs]=audioread(filepath_r); %读取语音信号的数据，赋给变量x1
%sui ji yu yin wen jian
filepath_s1='soundsrc\';
filepath_s1=strcat(filepath_s1,int2str(s1));
filepath_s1=strcat(filepath_s1,'.wav');

filepath_s2='soundsrc\';
filepath_s2=strcat(filepath_s2,int2str(s2));
filepath_s2=strcat(filepath_s2,'.wav');

filepath_s3='soundsrc\';
filepath_s3=strcat(filepath_s3,int2str(s3));
filepath_s3=strcat(filepath_s3,'.wav');


[y1,fs]=audioread(filepath_s1); %读取语音信号的数据，赋给变量x1
[y2,fs]=audioread(filepath_s2); %读取语音信号的数据，赋给变量x1

[y3,fs]=audioread(filepath_s3); %读取语音信号的数据，赋给变量x1


%n=length(x);
x=x(1:50000);
x=x(:);
y1=y1(1:50000);
y1=y1(:);
after1=y1+x;
audiowrite('sounddone\1.wav',after1,fs);%将编码写成wav格式
after1=audioread('sounddone\1.wav');
after1=awgn(after1,25);
a=randsrc(1,1,[1.25,1.5,1.75,2]);
after1=resample(after1,fs,a*fs/1.5);
audiowrite('sounddone\1.wav',after1,fs);%将编码写成wav格式


str1=int2str(s1);
st='picturesrc\';
str='.jpg';
sc1=[st,str1,str];
m=imread(sc1);
m=imnoise(m,'gaussian',0.002);
m1=imnoise(m,'salt & pepper',0.02);
imwrite(m1,'picturedone\1_finished.jpg','jpg')

y3=y3(1:50000);
y3=y3(:);
after3=y3+x;
audiowrite('sounddone\3.wav',after3,fs);%将编码写成wav格式
after3=audioread('sounddone\3.wav');
after3=awgn(after3,25);
a=randsrc(1,1,[1.25,1.5,1.75,2]);
after3=resample(after3,fs,a*fs/1.5);
audiowrite('sounddone\3.wav',after3,fs);%将编码写成wav格式


str3=int2str(s3);
st='picturesrc\';
str='.jpg';
sc3=[st,str3,str];
m=imread(sc3);
m=imnoise(m,'gaussian',0.002);
m3=imnoise(m,'salt & pepper',0.02);
imwrite(m3,'picturedone\3_finished.jpg','jpg')

y2=y2(1:50000);
y2=y2(:);
after2=y2+x;
%audiowrite('H:\matlab part\2.wav',after2,fs);%将编码写成wav格式
%after2=audioread('H:\matlab part\2.wav');
after2=awgn(after2,25);
a=randsrc(1,1,[1.25,1.5,1.75,2]);
after2=resample(after2,fs,a*fs/1.5);
audiowrite('sounddone\2.wav',after2,fs);%将编码写成wav格式

str2=int2str(s2);
st='picturesrc\';
str='.jpg';
sc2=[st,str2,str];
m=imread(sc2);
m=imnoise(m,'gaussian',0.002);
m2=imnoise(m,'salt & pepper',0.02);
%figure('visible','off');

imwrite(m2,'picturedone\2_finished.jpg','jpg')
%saveas(h,['E:\SRTP\code\picturedone\','2_finished','.jpg']);


y=1;
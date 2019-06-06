using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DDBDrawingLib
{
   /********************************************************************************************************************
   Contains all the operations required for placing items on a picture box and controlling the canvas objects
   ********************************************************************************************************************/
   public class Canvas
   {
      public Canvas(PictureBox pb,Color colorBackGround)
      {
         _mPicture=pb;
         _mBitMap=new Bitmap(_mPicture.Width,_mPicture.Height);
         _theGraphics=Graphics.FromImage(_mBitMap);
         BackGroundColor=colorBackGround;
         WorldCenter=new PointF(x:0.0f,y:0.0f);
         WorldXLength=1.0f;
         WorldYLength=1.0f;
      }

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public void CanvasSizeChanged()
      {
         if(_mPicture.Width>0 && _mPicture.Height>0)
         {
            _mBitMap=new Bitmap(_mPicture.Width,_mPicture.Height);
            _theGraphics=Graphics.FromImage(_mBitMap);
         }
      }

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public void GrowView()
      {
         const float factor=1.1f;
         const float maxAllowed=1e3f;
         if(WorldXLength>maxAllowed||WorldYLength>maxAllowed) return;
         WorldXLength*=factor;
         WorldYLength*=factor;
      }

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public void NarrowView()
      {
         const float factor=0.9f;
         const float minAllowed=1e-3f;
         if(WorldXLength<minAllowed||WorldYLength<minAllowed) return;   // avoid 
         WorldXLength*=factor;
         WorldYLength*=factor;
      }

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public void Clear()
      {
         _theGraphics.Clear(Color.Black);
      }

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public void BitMapToCanvas()
      {
         _mPicture.Image=_mBitMap;
      }

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public void MoveWorldPoint(PointF pdeltaCenter)
      {
         pdeltaCenter=RelativePixelPointToRelativeWorldPoint(pdeltaCenter);
         WorldCenter.X-=pdeltaCenter.X;
         WorldCenter.Y-=pdeltaCenter.Y;
      }

      /*****************************************************************************************************************
      Convert world points to pixel points for drawing
      *****************************************************************************************************************/
      //private List<PointF> WorldToPixes(List<PointF> wpts)
      //{
      //   var retval=wpts.ConvertAll(WorldPointToPixelPoint);
      //   return retval;
      //}

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public float XWorldLengthToPixelLength(float wlen)
      {
         return RelativeWorldPointToRelativePixelPoint(new PointF(wlen,0.0f)).X;
      } 

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public float YWorldLengthToPixelLength(float wlen)
      {
         return RelativeWorldPointToRelativePixelPoint(new PointF(0.0f,wlen)).Y;
      } 

      /*****************************************************************************************************************
      Convert a world point to a pixel point
      *****************************************************************************************************************/
      public PointF WorldPointToPixelPoint(PointF wpt)
      {
         wpt=new PointF(wpt.X,-wpt.Y);  // Let x up be positive
        
         var canvasXMagInPixels=_mPicture.Width*0.5f;
         var canvasYMagInPixels=_mPicture.Height*0.5f;

         // Move the origin based on world center
         var worldPointXWithCenter=wpt.X-WorldCenter.X;
         var worldPointYWithCenter=wpt.Y-WorldCenter.Y;
         
         // Normallize the world point
         var relativeX=worldPointXWithCenter/WorldXLength;
         var relativeY=worldPointYWithCenter/WorldYLength;
         
         // Convert Normalized world point to pixel positions
         var x=canvasXMagInPixels+(relativeX*canvasXMagInPixels);
         var y=canvasYMagInPixels+(relativeY*canvasYMagInPixels);

         // Return pixel position for the world point
         return new PointF(x,y);
      }

      /*****************************************************************************************************************
      Convert a pixel point to a world point
      *****************************************************************************************************************/
      public PointF PixelPointToWorldPoint(PointF ppt)
      {
         var canvasXMagInPixels=_mPicture.Width*0.5f;
         var canvasYMagInPixels=_mPicture.Height*0.5f;

         // Subtract out screen co-ordinates
         var relativeX=ppt.X-=canvasXMagInPixels;
         var relativeY=ppt.Y-=canvasYMagInPixels;

         // Normalize
         relativeX/=canvasXMagInPixels;
         relativeY/=canvasYMagInPixels;

         // De-Normalize to world points
         relativeX*=WorldXLength;
         relativeY*=WorldYLength;

         // Add centers
         relativeX+=WorldCenter.X;
         relativeY+=WorldCenter.Y;

         return new PointF(relativeX,-relativeY); // Y axis is inverted
      }

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public void DrawText(string text,Color c,PointF start,float size)
      {
         var topleft=WorldPointToPixelPoint(start);
         var pxlSize=YWorldLengthToPixelLength(size);
         if(pxlSize>0.05)
         {
            _theGraphics.DrawString(text,new Font(FontFamily.GenericMonospace,pxlSize,FontStyle.Regular),
               new SolidBrush(c),topleft);
         }
      }

      /*****************************************************************************************************************
      *****************************************************************************************************************/
      public void DrawLine(Color c,PointF start,PointF end)
      {
         var pxlStart=WorldPointToPixelPoint(start);
         var pxlEnd=WorldPointToPixelPoint(end);
         _theGraphics.DrawLine(new Pen(c),pxlStart,pxlEnd);
      }

     /*****************************************************************************************************************
     *****************************************************************************************************************/
      public void DrawCircle(Color c,PointF center,float radius)
      {
        var pxlRadius = XWorldLengthToPixelLength(radius);
        var pxlCenter=WorldPointToPixelPoint(center);
        pxlCenter.X-=pxlRadius/4;
        pxlCenter.Y-=pxlRadius/4;
        _theGraphics.DrawEllipse(new Pen(c),pxlCenter.X,pxlCenter.Y,pxlRadius/2,pxlRadius/2);
      }

     /*****************************************************************************************************************
     *****************************************************************************************************************/
     public void DrawFilledCircle(Color c,PointF center,float radius)
     {
       var pxlRadius = XWorldLengthToPixelLength(radius);
       var pxlCenter = WorldPointToPixelPoint(center);
       pxlCenter.X-=pxlRadius/4;
       pxlCenter.Y-=pxlRadius/4;
       _theGraphics.FillEllipse(new SolidBrush(Color.Red),new Rectangle((int)pxlCenter.X,(int)pxlCenter.Y,(int)pxlRadius/2,(int)pxlRadius/2));
     }

     /*****************************************************************************************************************
     *****************************************************************************************************************/
     public void DrawSquare(Color c,float x,float y,float size)
     {
       var pxlSizeX=XWorldLengthToPixelLength(size);
       var pxlSizeY=YWorldLengthToPixelLength(size);
       var pxlTopLeft=WorldPointToPixelPoint(new PointF(x,y));
       _theGraphics.FillRectangle(new SolidBrush(c),pxlTopLeft.X,pxlTopLeft.Y,pxlSizeX,pxlSizeY);
     }

    /*****************************************************************************************************************
    *****************************************************************************************************************/
    public PointF RelativePixelPointToRelativeWorldPoint(PointF ppt)
      {
         var canvasXMagInPixels=_mPicture.Width*0.5f;
         var canvasYMagInPixels=_mPicture.Height*0.5f;

         // Normalize
         var relativeX=ppt.X/canvasXMagInPixels;
         var relativeY=ppt.Y/canvasYMagInPixels;

         // De-Normalize to world points
         relativeX*=WorldXLength;
         relativeY*=WorldYLength;

         return new PointF(relativeX,relativeY);
      }

      /*****************************************************************************************************************
      Relative world point to relative pixel point
      *****************************************************************************************************************/
      public PointF RelativeWorldPointToRelativePixelPoint(PointF wpt)
      {
         var canvasXMagInPixels=_mPicture.Width*0.5f;
         var canvasYMagInPixels=_mPicture.Height*0.5f;

         // Normalize world point
         var relativeX=wpt.X/WorldXLength;
         var relativeY=wpt.Y/WorldYLength;

         // Denormalize to pixel points
         relativeX*=canvasXMagInPixels;
         relativeY*=canvasYMagInPixels;

         return new PointF(relativeX,relativeY);
      }

     public float Width=>_mPicture.Width;
     public float Height=>_mPicture.Height;

     private Graphics _theGraphics;
     private readonly PictureBox _mPicture;
     private Bitmap _mBitMap;
     // ReSharper disable once UnusedAutoPropertyAccessor.Local
     private Color BackGroundColor{get;set;}
     public PointF WorldCenter;
     public float WorldXLength{get;set;}
     public float WorldYLength{get;set;}
   }
}

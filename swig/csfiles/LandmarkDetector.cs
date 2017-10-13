//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SharpFace
{

    public class LandmarkDetector
    {
        public static bool DetectLandmarksInVideo(SWIGTYPE_p_cv__Mat_T_uchar_t grayscale_image, SWIGTYPE_p_CLNF clnf_model, SWIGTYPE_p_FaceModelParameters arg2)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectLandmarksInVideo__SWIG_0(SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(grayscale_image), SWIGTYPE_p_CLNF.getCPtr(clnf_model), SWIGTYPE_p_FaceModelParameters.getCPtr(arg2));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectLandmarksInVideo(SWIGTYPE_p_cv__Mat_T_uchar_t grayscale_image, SWIGTYPE_p_cv__Rect_T_double_t bounding_box, SWIGTYPE_p_CLNF clnf_model, SWIGTYPE_p_FaceModelParameters arg3)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectLandmarksInVideo__SWIG_1(SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(grayscale_image), SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(bounding_box), SWIGTYPE_p_CLNF.getCPtr(clnf_model), SWIGTYPE_p_FaceModelParameters.getCPtr(arg3));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectLandmarksInImage(SWIGTYPE_p_cv__Mat_T_uchar_t grayscale_image, SWIGTYPE_p_CLNF clnf_model, SWIGTYPE_p_FaceModelParameters arg2)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectLandmarksInImage__SWIG_0(SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(grayscale_image), SWIGTYPE_p_CLNF.getCPtr(clnf_model), SWIGTYPE_p_FaceModelParameters.getCPtr(arg2));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectLandmarksInImage(SWIGTYPE_p_cv__Mat_T_uchar_t grayscale_image, SWIGTYPE_p_cv__Rect_T_double_t bounding_box, SWIGTYPE_p_CLNF clnf_model, SWIGTYPE_p_FaceModelParameters arg3)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectLandmarksInImage__SWIG_1(SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(grayscale_image), SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(bounding_box), SWIGTYPE_p_CLNF.getCPtr(clnf_model), SWIGTYPE_p_FaceModelParameters.getCPtr(arg3));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Vec6d GetPoseCamera(SWIGTYPE_p_CLNF clnf_model, double fx, double fy, double cx, double cy)
        {
            SWIGTYPE_p_cv__Vec6d ret = new SWIGTYPE_p_cv__Vec6d(LandmarkDetectorPINVOKE.GetPoseCamera(SWIGTYPE_p_CLNF.getCPtr(clnf_model), fx, fy, cx, cy), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Vec6d GetPoseWorld(SWIGTYPE_p_CLNF clnf_model, double fx, double fy, double cx, double cy)
        {
            SWIGTYPE_p_cv__Vec6d ret = new SWIGTYPE_p_cv__Vec6d(LandmarkDetectorPINVOKE.GetPoseWorld(SWIGTYPE_p_CLNF.getCPtr(clnf_model), fx, fy, cx, cy), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Vec6d GetCorrectedPoseCamera(SWIGTYPE_p_CLNF clnf_model, double fx, double fy, double cx, double cy)
        {
            SWIGTYPE_p_cv__Vec6d ret = new SWIGTYPE_p_cv__Vec6d(LandmarkDetectorPINVOKE.GetCorrectedPoseCamera(SWIGTYPE_p_CLNF.getCPtr(clnf_model), fx, fy, cx, cy), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Vec6d GetCorrectedPoseWorld(SWIGTYPE_p_CLNF clnf_model, double fx, double fy, double cx, double cy)
        {
            SWIGTYPE_p_cv__Vec6d ret = new SWIGTYPE_p_cv__Vec6d(LandmarkDetectorPINVOKE.GetCorrectedPoseWorld(SWIGTYPE_p_CLNF.getCPtr(clnf_model), fx, fy, cx, cy), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static void get_video_input_output_params(StringList input_video_file, StringList output_files, StringList output_video_files, /* cstype */ out bool world_coordinates_pose, /*cstype*/ out string output_codec, StringList arguments)
        {
            LandmarkDetectorPINVOKE.get_video_input_output_params(StringList.getCPtr(input_video_file), StringList.getCPtr(output_files), StringList.getCPtr(output_video_files), out world_coordinates_pose, out output_codec, StringList.getCPtr(arguments));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void get_camera_params(/* cstype */ out int device, /* cstype */ out float fx, /* cstype */ out float fy, /* cstype */ out float cx, /* cstype */ out float cy, StringList arguments)
        {
            LandmarkDetectorPINVOKE.get_camera_params(out device, out fx, out fy, out cx, out cy, StringList.getCPtr(arguments));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void get_image_input_output_params(StringList input_image_files, StringList output_feature_files, StringList output_pose_files, StringList output_image_files, CVDoubleRectList input_bounding_boxes, StringList arguments)
        {
            LandmarkDetectorPINVOKE.get_image_input_output_params(StringList.getCPtr(input_image_files), StringList.getCPtr(output_feature_files), StringList.getCPtr(output_pose_files), StringList.getCPtr(output_image_files), CVDoubleRectList.getCPtr(input_bounding_boxes), StringList.getCPtr(arguments));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void matchTemplate_m(SWIGTYPE_p_cv__Mat_T_float_t input_img, SWIGTYPE_p_cv__Mat_T_double_t img_dft, SWIGTYPE_p_cv__Mat _integral_img, SWIGTYPE_p_cv__Mat _integral_img_sq, SWIGTYPE_p_cv__Mat_T_float_t templ, Int_DoubleMatMap templ_dfts, SWIGTYPE_p_cv__Mat_T_float_t result, int method)
        {
            LandmarkDetectorPINVOKE.matchTemplate_m(SWIGTYPE_p_cv__Mat_T_float_t.getCPtr(input_img), SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(img_dft), SWIGTYPE_p_cv__Mat.getCPtr(_integral_img), SWIGTYPE_p_cv__Mat.getCPtr(_integral_img_sq), SWIGTYPE_p_cv__Mat_T_float_t.getCPtr(templ), Int_DoubleMatMap.getCPtr(templ_dfts), SWIGTYPE_p_cv__Mat_T_float_t.getCPtr(result), method);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static SWIGTYPE_p_cv__Matx22d AlignShapesKabsch2D(SWIGTYPE_p_cv__Mat_T_double_t align_from, SWIGTYPE_p_cv__Mat_T_double_t align_to)
        {
            SWIGTYPE_p_cv__Matx22d ret = new SWIGTYPE_p_cv__Matx22d(LandmarkDetectorPINVOKE.AlignShapesKabsch2D(SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(align_from), SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(align_to)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Matx22d AlignShapesWithScale(SWIGTYPE_p_cv__Mat_T_double_t src, SWIGTYPE_p_cv__Mat_T_double_t dst)
        {
            SWIGTYPE_p_cv__Matx22d ret = new SWIGTYPE_p_cv__Matx22d(LandmarkDetectorPINVOKE.AlignShapesWithScale(SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(src), SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(dst)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static void Project(SWIGTYPE_p_cv__Mat_T_double_t dest, SWIGTYPE_p_cv__Mat_T_double_t mesh, double fx, double fy, double cx, double cy)
        {
            LandmarkDetectorPINVOKE.Project(SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(dest), SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(mesh), fx, fy, cx, cy);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void DrawBox(SWIGTYPE_p_cv__Mat image, SWIGTYPE_p_cv__Vec6d pose, SWIGTYPE_p_cv__Scalar color, int thickness, float fx, float fy, float cx, float cy)
        {
            LandmarkDetectorPINVOKE.DrawBox__SWIG_0(SWIGTYPE_p_cv__Mat.getCPtr(image), SWIGTYPE_p_cv__Vec6d.getCPtr(pose), SWIGTYPE_p_cv__Scalar.getCPtr(color), thickness, fx, fy, cx, cy);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static CVPoint2DPairList CalculateBox(SWIGTYPE_p_cv__Vec6d pose, float fx, float fy, float cx, float cy)
        {
            CVPoint2DPairList ret = new CVPoint2DPairList(LandmarkDetectorPINVOKE.CalculateBox(SWIGTYPE_p_cv__Vec6d.getCPtr(pose), fx, fy, cx, cy), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static void DrawBox(CVPointPairList lines, SWIGTYPE_p_cv__Mat image, SWIGTYPE_p_cv__Scalar color, int thickness)
        {
            LandmarkDetectorPINVOKE.DrawBox__SWIG_1(CVPointPairList.getCPtr(lines), SWIGTYPE_p_cv__Mat.getCPtr(image), SWIGTYPE_p_cv__Scalar.getCPtr(color), thickness);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static CVPoint2DList CalculateLandmarks(SWIGTYPE_p_cv__Mat_T_double_t shape2D, SWIGTYPE_p_cv__Mat_T_int_t visibilities)
        {
            CVPoint2DList ret = new CVPoint2DList(LandmarkDetectorPINVOKE.CalculateLandmarks__SWIG_0(SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(shape2D), SWIGTYPE_p_cv__Mat_T_int_t.getCPtr(visibilities)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static CVPoint2DList CalculateLandmarks(CLNF clnf_model)
        {
            CVPoint2DList ret = new CVPoint2DList(LandmarkDetectorPINVOKE.CalculateLandmarks__SWIG_1(CLNF.getCPtr(clnf_model)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static void DrawLandmarks(SWIGTYPE_p_cv__Mat img, CVPointList landmarks)
        {
            LandmarkDetectorPINVOKE.DrawLandmarks(SWIGTYPE_p_cv__Mat.getCPtr(img), CVPointList.getCPtr(landmarks));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void Draw(SWIGTYPE_p_cv__Mat img, SWIGTYPE_p_cv__Mat_T_double_t shape2D, SWIGTYPE_p_cv__Mat_T_int_t visibilities)
        {
            LandmarkDetectorPINVOKE.Draw__SWIG_0(SWIGTYPE_p_cv__Mat.getCPtr(img), SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(shape2D), SWIGTYPE_p_cv__Mat_T_int_t.getCPtr(visibilities));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void Draw(SWIGTYPE_p_cv__Mat img, SWIGTYPE_p_cv__Mat_T_double_t shape2D)
        {
            LandmarkDetectorPINVOKE.Draw__SWIG_1(SWIGTYPE_p_cv__Mat.getCPtr(img), SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(shape2D));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void Draw(SWIGTYPE_p_cv__Mat img, CLNF clnf_model)
        {
            LandmarkDetectorPINVOKE.Draw__SWIG_2(SWIGTYPE_p_cv__Mat.getCPtr(img), CLNF.getCPtr(clnf_model));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static SWIGTYPE_p_cv__Matx33d Euler2RotationMatrix(SWIGTYPE_p_cv__Vec3d eulerAngles)
        {
            SWIGTYPE_p_cv__Matx33d ret = new SWIGTYPE_p_cv__Matx33d(LandmarkDetectorPINVOKE.Euler2RotationMatrix(SWIGTYPE_p_cv__Vec3d.getCPtr(eulerAngles)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Vec3d RotationMatrix2Euler(SWIGTYPE_p_cv__Matx33d rotation_matrix)
        {
            SWIGTYPE_p_cv__Vec3d ret = new SWIGTYPE_p_cv__Vec3d(LandmarkDetectorPINVOKE.RotationMatrix2Euler(SWIGTYPE_p_cv__Matx33d.getCPtr(rotation_matrix)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Vec3d Euler2AxisAngle(SWIGTYPE_p_cv__Vec3d euler)
        {
            SWIGTYPE_p_cv__Vec3d ret = new SWIGTYPE_p_cv__Vec3d(LandmarkDetectorPINVOKE.Euler2AxisAngle(SWIGTYPE_p_cv__Vec3d.getCPtr(euler)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Vec3d AxisAngle2Euler(SWIGTYPE_p_cv__Vec3d axis_angle)
        {
            SWIGTYPE_p_cv__Vec3d ret = new SWIGTYPE_p_cv__Vec3d(LandmarkDetectorPINVOKE.AxisAngle2Euler(SWIGTYPE_p_cv__Vec3d.getCPtr(axis_angle)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Matx33d AxisAngle2RotationMatrix(SWIGTYPE_p_cv__Vec3d axis_angle)
        {
            SWIGTYPE_p_cv__Matx33d ret = new SWIGTYPE_p_cv__Matx33d(LandmarkDetectorPINVOKE.AxisAngle2RotationMatrix(SWIGTYPE_p_cv__Vec3d.getCPtr(axis_angle)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static SWIGTYPE_p_cv__Vec3d RotationMatrix2AxisAngle(SWIGTYPE_p_cv__Matx33d rotation_matrix)
        {
            SWIGTYPE_p_cv__Vec3d ret = new SWIGTYPE_p_cv__Vec3d(LandmarkDetectorPINVOKE.RotationMatrix2AxisAngle(SWIGTYPE_p_cv__Matx33d.getCPtr(rotation_matrix)), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectFaces(CVDoubleRectList o_regions, SWIGTYPE_p_cv__Mat_T_uchar_t intensity)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectFaces__SWIG_0(CVDoubleRectList.getCPtr(o_regions), SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(intensity));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectFaces(CVDoubleRectList o_regions, SWIGTYPE_p_cv__Mat_T_uchar_t intensity, SWIGTYPE_p_cv__CascadeClassifier classifier)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectFaces__SWIG_1(CVDoubleRectList.getCPtr(o_regions), SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(intensity), SWIGTYPE_p_cv__CascadeClassifier.getCPtr(classifier));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectSingleFace(SWIGTYPE_p_cv__Rect_T_double_t o_region, SWIGTYPE_p_cv__Mat_T_uchar_t intensity, SWIGTYPE_p_cv__CascadeClassifier classifier, SWIGTYPE_p_cv__Point preference)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectSingleFace__SWIG_0(SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(o_region), SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(intensity), SWIGTYPE_p_cv__CascadeClassifier.getCPtr(classifier), SWIGTYPE_p_cv__Point.getCPtr(preference));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectSingleFace(SWIGTYPE_p_cv__Rect_T_double_t o_region, SWIGTYPE_p_cv__Mat_T_uchar_t intensity, SWIGTYPE_p_cv__CascadeClassifier classifier)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectSingleFace__SWIG_1(SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(o_region), SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(intensity), SWIGTYPE_p_cv__CascadeClassifier.getCPtr(classifier));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectFacesHOG(CVDoubleRectList o_regions, SWIGTYPE_p_cv__Mat_T_uchar_t intensity, DoubleList confidences)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectFacesHOG__SWIG_0(CVDoubleRectList.getCPtr(o_regions), SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(intensity), DoubleList.getCPtr(confidences));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectFacesHOG(CVDoubleRectList o_regions, SWIGTYPE_p_cv__Mat_T_uchar_t intensity, SWIGTYPE_p_dlib__frontal_face_detector classifier, DoubleList confidences)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectFacesHOG__SWIG_1(CVDoubleRectList.getCPtr(o_regions), SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(intensity), SWIGTYPE_p_dlib__frontal_face_detector.getCPtr(classifier), DoubleList.getCPtr(confidences));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectSingleFaceHOG(SWIGTYPE_p_cv__Rect_T_double_t o_region, SWIGTYPE_p_cv__Mat_T_uchar_t intensity, SWIGTYPE_p_dlib__frontal_face_detector classifier, /* cstype */ out double confidence, SWIGTYPE_p_cv__Point preference)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectSingleFaceHOG__SWIG_0(SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(o_region), SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(intensity), SWIGTYPE_p_dlib__frontal_face_detector.getCPtr(classifier), out confidence, SWIGTYPE_p_cv__Point.getCPtr(preference));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static bool DetectSingleFaceHOG(SWIGTYPE_p_cv__Rect_T_double_t o_region, SWIGTYPE_p_cv__Mat_T_uchar_t intensity, SWIGTYPE_p_dlib__frontal_face_detector classifier, /* cstype */ out double confidence)
        {
            bool ret = LandmarkDetectorPINVOKE.DetectSingleFaceHOG__SWIG_1(SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(o_region), SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(intensity), SWIGTYPE_p_dlib__frontal_face_detector.getCPtr(classifier), out confidence);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static void ReadMatBin(SWIGTYPE_p_std__ifstream stream, SWIGTYPE_p_cv__Mat output_mat)
        {
            LandmarkDetectorPINVOKE.ReadMatBin(SWIGTYPE_p_std__ifstream.getCPtr(stream), SWIGTYPE_p_cv__Mat.getCPtr(output_mat));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void ReadMat(SWIGTYPE_p_std__ifstream stream, SWIGTYPE_p_cv__Mat output_matrix)
        {
            LandmarkDetectorPINVOKE.ReadMat(SWIGTYPE_p_std__ifstream.getCPtr(stream), SWIGTYPE_p_cv__Mat.getCPtr(output_matrix));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static void SkipComments(SWIGTYPE_p_std__ifstream stream)
        {
            LandmarkDetectorPINVOKE.SkipComments(SWIGTYPE_p_std__ifstream.getCPtr(stream));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}

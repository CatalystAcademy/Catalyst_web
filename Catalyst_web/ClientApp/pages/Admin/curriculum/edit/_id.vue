<template>
  <div>
    <form @submit.prevent="submitForm" :action="`/api/Courses/Edit/${courseId}`">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="titleArm">Title in Armenian</label>
            <input v-model="createData.titleArm" type="text" id="titleArm" placeholder="Title in Armenian" name="titleArm">
          </div>

          <div class="col">
            <label for="titleEng">Title in English</label>
            <input v-model="createData.titleEng" type="text" id="titleEng" placeholder="Title in English" name="titleEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="descriptionArm">Description in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionArm" id="descriptionArm" placeholder="Description in Armenian" name="descriptionArm"></textarea>
          </div>

          <div class="col">
            <label for="descriptionEng">Description in English</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionEng" id="descriptionEng" placeholder="Description in English" name="descriptionEng"></textarea>
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="startDate">Start Date</label>
            <input v-model="createData.startDate" type="date" id="startDate" name="startDate">
          </div>

          <div class="col">
            <label for="endDate">End Date</label>
            <input v-model="createData.endDate" type="date" id="endDate" name="endDate">
          </div>
        </div>

        <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
      </div>
    </form>
  </div>
</template>

<script>
  import https from 'https';

  export default {
    name: 'EditCurriculum',
    data() {
      return {
        curriculumId: null,
        createData: { titleArm: '', titleEng: '', descriptionArm: '', descriptionEng: '', startDate: '', endDate: '' },
      };
    },
    async created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }

      // Check if a course ID is provided in the route parameters
      if (this.$route.params.id) {
        this.curriculumId = this.$route.params.id;
        await this.fetchCourseDetails();
      }
    },
    methods: {
      async fetchCourseDetails() {
        try {
          const response = await this.$axios.get(`/api/CurriculumDetails/${this.curriculumId}`);
          this.createData = { ...response.data };
        } catch (error) {
          console.error('Error fetching Curriculum details:', error);
        }
      },
      async submitForm() {
        try {
          const response = await this.$axios.put(`/api/Curriculums/Edit/${this.curriculumId}`, this.createData);
          console.log("response", response);
          if (response) {
            this.$toasted.success('Edit successful!');
            // Redirect after a successful edit
            window.location = "/admin/curriculum/list";
          }
        } catch (error) {
          // Handle error and display message
          this.$toasted.error('An error occurred. Please try again.');
        }
      },
    },
  };
</script>
